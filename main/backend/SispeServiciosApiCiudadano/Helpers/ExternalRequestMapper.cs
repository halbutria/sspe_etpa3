using SispeServiciosEventos.Queue.v1;
using System.Collections;
using System.Reflection;

namespace SispeServicios.Api.Ciudadano.Helpers
{

    public static class ExternalRequestMapper
    {
        public static List<ExternalRequestBodyDto> GetExternalRequestBodies<T>(T model, string processType) where T : class
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var result = new List<ExternalRequestBodyDto>();

            // Obtener todas las propiedades del modelo
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);

            foreach (var property in properties)
            {
                // Verificar si la propiedad es una colección (Lista, IEnumerable, etc.)
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) &&
                    property.PropertyType != typeof(string)) // Excluir cadenas
                {
                    // Buscar la tabla en el diccionario basado en el nombre de la propiedad
                    if (!ReportTables.Tables.TryGetValue(property.Name, out var tableName))
                    {
                        Console.WriteLine($"La propiedad {property.Name} no está definida en el diccionario ReportTables.Tables.");
                        continue; // Saltar si no se encuentra
                    }

                    // Intentar acceder a la propiedad como una colección
                    var list = property.GetValue(model) as IEnumerable;
                    if (list == null) continue;

                    // Obtener el tipo de los elementos en la colección (si es genérico)
                    var itemType = property.PropertyType.IsGenericType
                        ? property.PropertyType.GetGenericArguments()[0]
                        : null;

                    foreach (var item in list)
                    {
                        // Si no se puede determinar el tipo genérico, saltar
                        if (itemType == null) continue;

                        // Buscar la propiedad "Id" en el tipo del elemento
                        var idProperty = itemType.GetProperty("Id", BindingFlags.Public | BindingFlags.Instance);
                        if (idProperty == null) continue;

                        // Obtener el valor del Id
                        var idValue = idProperty.GetValue(item)?.ToString();
                        if (string.IsNullOrEmpty(idValue)) continue;

                        // Crear el objeto ExternalRequestBodyDto y agregarlo al resultado
                        result.Add(new ExternalRequestBodyDto
                        {
                            Tabla = tableName, // Usar el valor mapeado en el diccionario
                            Registro = new RegistroDto
                            {
                                Id = idValue,
                                Proceso = processType
                            }
                        });
                    }
                }
            }

            // Verificar si el modelo principal tiene un Id y agregarlo como registro principal
            var idPropertyModel = typeof(T).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance);
            var idValueModel = idPropertyModel?.GetValue(model)?.ToString();
            if (!string.IsNullOrEmpty(idValueModel))
            {
                result.Add(new ExternalRequestBodyDto
                {
                    Tabla = "Ciudadano", // Nombre de la tabla principal
                    Registro = new RegistroDto
                    {
                        Id = idValueModel,
                        Proceso = processType
                    }
                });
            }

            return result;
        }



        // Método ajustado para GetDifferences
        public static (List<ExternalRequestBodyDto>, bool snPrincipalChange)
        GetDifferences<TBase, TReference, TAfter>(
        TBase entity,
        TReference dto,
        TAfter entityAfter,
        Dictionary<string, string>? fieldsToValidate = null
        )
        {
            if (entity == null || dto == null)
                throw new ArgumentNullException("Ni la entidad ni el DTO pueden ser nulos.");

            var differences = new List<(string EntityName, string PropertyName, object? EntityId, object? EntityValue, object? DtoValue)>();
            bool snPrincipalChange = false;



            // Obtiene el ID de la entidad para usarlo como referencia en las diferencias detectadas
            var idProperty = typeof(TBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance);
            var entityId = idProperty?.GetValue(entity);

            // Validación de los campos simples definidos en el diccionario
            if (fieldsToValidate != null)
            {
                foreach (var field in fieldsToValidate)
                {
                    var entityProp = typeof(TBase).GetProperty(field.Key, BindingFlags.Public | BindingFlags.Instance);
                    var dtoProp = typeof(TReference).GetProperty(field.Key, BindingFlags.Public | BindingFlags.Instance);

                    if (entityProp != null && dtoProp != null)
                    {
                        var entityValue = entityProp.GetValue(entity);
                        var dtoValue = dtoProp.GetValue(dto);

                        // Compara los valores; si son diferentes, registra el cambio
                        if (!Equals(entityValue, dtoValue))
                        {
                            snPrincipalChange = true;
                            differences.Add((field.Value, field.Key, entityId, entityValue, dtoValue));
                        }
                    }
                }
            }

            var result = new List<ExternalRequestBodyDto>();
            // Validación de campos complejos basados en listas
            var complexFields = GetComplexFieldsDictionary();
            foreach (var field in complexFields)
            {
                var entityProp = typeof(TBase).GetProperty(field.Key, BindingFlags.Public | BindingFlags.Instance);
                var dtoProp = typeof(TReference).GetProperty(field.Value.DtoField, BindingFlags.Public | BindingFlags.Instance);

                if (entityProp == null || dtoProp == null) continue;

                // Obtén las listas desde la entidad y el DTO
                var entityList = entityProp.GetValue(entity) as IEnumerable ?? Enumerable.Empty<object>();
                var dtoList = dtoProp.GetValue(dto) as IEnumerable ?? Enumerable.Empty<object>();

                var entityIdPropAfter = typeof(TAfter).GetProperty(field.Key, BindingFlags.Public | BindingFlags.Instance);
                var entityIdAfter = entityIdPropAfter?.GetValue(entityAfter);

                // Crear la lista de IDs para manejar ambos casos
                IEnumerable<object> entityIdList;

                // Determinar si es una colección o un único objeto
                if (entityIdAfter is IEnumerable<object> enumerableEntityIdAfter)
                {
                    // Si es una colección, usaremos esta lista directamente
                    entityIdList = enumerableEntityIdAfter;
                }
                else
                {
                    // Si es un único objeto, lo envolvemos en una lista
                    entityIdList = new List<object> { entityIdAfter };
                }

                // Extrae los valores de ID de cada elemento en la lista de la entidad
                var entityValues = entityList
                    .Cast<object>()
                    .Select(x =>
                    {
                        // Usa EntityIdGetter definido en el diccionario para obtener el ID de cada elemento
                        return field.Value.EntityIdGetter(x);
                    })
                    .ToList();

                if (!ReportTables.Tables.TryGetValue(field.Key, out var tableName))
                {
                    Console.WriteLine($"La propiedad {field} no está definida en el diccionario ReportTables.Tables.");
                    continue; // Saltar si no se encuentra
                }

                // Los valores del DTO ya están en la lista, no necesitan transformación
                var dtoValues = dtoList.Cast<object>().ToList();

                // Compara las listas para detectar diferencias
                if (!entityValues.SequenceEqual(dtoValues))
                {
                    snPrincipalChange = true;
                    differences.Add((field.Key, "List", entityId, entityValues, dtoValues));

                    foreach (var objectId in entityIdList)
                    {
                        var trimmedObject = new
                        {
                            Id = objectId.GetType().GetProperty("Id")?.GetValue(objectId)
                        };

                        var jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(
                            Newtonsoft.Json.JsonConvert.SerializeObject(trimmedObject)
                        );

                        // Acceder a la propiedad Id
                        string idValue = jsonObject.Id?.ToString(); // Accede a la propiedad dinámica "Id"

                        result.Add(new ExternalRequestBodyDto
                        {
                            Tabla = tableName,
                            Registro = new RegistroDto
                            {
                                Id = idValue,
                                Proceso = entityValues.Count() == 0 ? "Creacion" : "Actualizacion"
                            }
                        });
                    }


                }
            }

            return (result, snPrincipalChange);
        }

        // Diccionario que define los campos complejos a validar
        private static Dictionary<string, ComplexFieldMapping> GetComplexFieldsDictionary()
        {
            return new Dictionary<string, ComplexFieldMapping>
        {
            {
                "CargoInteres", new ComplexFieldMapping
                {
                    DtoField = "CargoIneteres",
                    EntityIdGetter = entity => ((dynamic)entity).CargoInteresId
                }
            },
            {
                "Discapacidad", new ComplexFieldMapping
                {
                    DtoField = "CondicionDiscapacidad",
                    EntityIdGetter = entity => ((dynamic)entity).DisacapacidaId
                }
            },
            {
                "CondicionMental", new ComplexFieldMapping
                {
                    DtoField = "CondicionSaludMental",
                    EntityIdGetter = entity => ((dynamic)entity).CondicionMentalId
                }
            },
            {
                "TipoPoblacion", new ComplexFieldMapping
                {
                    DtoField = "TipoPoblacion",
                    EntityIdGetter = entity => ((dynamic)entity).TipoPoblacionId
                }
            },
            {
                "GrupoEtnico", new ComplexFieldMapping
                {
                    DtoField = "GrupoEtnico",
                    EntityIdGetter = entity => ((dynamic)entity).GrupoEtnicoId
                }
            }
        };
        }

        // Clase auxiliar para definir el mapeo entre campos complejos
        private class ComplexFieldMapping
        {
            public string DtoField { get; set; } // Nombre del campo en el DTO
            public Func<object, object?> EntityIdGetter { get; set; } // Cómo obtener el ID de los elementos en la entidad
        }

    }
}