namespace SispeServiciosApiCiudadano.DTOs
{
    public class EncuentaIesDTO
    {
        public string Pregunta { get; set; } = string.Empty;
        public string Respuesta { get; set; } = string.Empty;
        public int Orden {  get; set; }
    }

    public class ParametricosEncuentaIesDTO 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;

        public List<ParametricosEncuentaIesDTO> ObtenerParametricos() {
            return new List<ParametricosEncuentaIesDTO>
            {
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Graduado",
                    Tipo = "ListaEgresado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Egresado Ejemplo 2",
                    Tipo = "ListaEgresado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Antes de graduarse",
                    Tipo = "TiempoTranscurridoPrimerEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Menos de seis meses",
                    Tipo = "TiempoTranscurridoPrimerEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Entre seis meses y un año",
                    Tipo = "TiempoTranscurridoPrimerEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Más de un año",
                    Tipo = "TiempoTranscurridoPrimerEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "1",
                    Tipo = "EmpleosRelacionados"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "2",
                    Tipo = "EmpleosRelacionados"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "3",
                    Tipo = "EmpleosRelacionados"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "4",
                    Tipo = "EmpleosRelacionados"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "5 o más",
                    Tipo = "EmpleosRelacionados"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Completo",
                    Tipo = "TiemposTrabajoSemanal"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Parcial",
                    Tipo = "TiemposTrabajoSemanal"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Por horas",
                    Tipo = "TiemposTrabajoSemanal"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Igual o menor a dos salarios mínimos",
                    Tipo = "IngresoSalariales"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Mayor a dos salarios mínimos y menor a cuatro salarios mínimos",
                    Tipo = "IngresoSalariales"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Mayor a cuatro salarios mínimos y menor a seis salarios mínimos",
                    Tipo = "IngresoSalariales"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Mayor de seis salarios mínimos",
                    Tipo = "IngresoSalariales"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Para mejorar la utilización de sus capacidades o su formación",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Desea mejorar sus ingresos",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Desea trabajar menos horas",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Porque el trabajo actual es temporal o a término fijo",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Problemas en el trabajo",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 6,
                    Nombre = "No le gusta su trabajo actual",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 7,
                    Nombre = "Su trabajo actual exige mucho esfuerzo físico y/o mental",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 8,
                    Nombre = "Problemas ambientales (aire, olores, ruido, temperatura)",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 9,
                    Nombre = "Otro",
                    Tipo = "MotivosCambioEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Bolsa de empleo de la IES",
                    Tipo = "MediosEmpleadoParaBusquedaEmeplado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Contactos personales",
                    Tipo = "MediosEmpleadoParaBusquedaEmeplado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Práctica profesional",
                    Tipo = "MediosEmpleadoParaBusquedaEmeplado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Medios de comunicación masiva",
                    Tipo = "MediosEmpleadoParaBusquedaEmeplado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Convocatorias",
                    Tipo = "MediosEmpleadoParaBusquedaEmeplado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 6,
                    Nombre = "Plataformas virtuales (elempleo.com, trabajando.com, UAESPE)",
                    Tipo = "MediosEmpleadoParaBusquedaEmeplado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Público",
                    Tipo = "SectoresEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Privado",
                    Tipo = "SectoresEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Mixto",
                    Tipo = "SectoresEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Menos de un año",
                    Tipo = "AntiguedadesEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Entre uno y dos años",
                    Tipo = "AntiguedadesEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Entre dos y tres años",
                    Tipo = "AntiguedadesEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Más de tres años",
                    Tipo = "AntiguedadesEmpleo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Directivo",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Jefe de área",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Supervisor",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Empresario",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Técnico",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 6,
                    Nombre = "Operativo",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 7,
                    Nombre = "Profesional",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 8,
                    Nombre = "Profesional especializado",
                    Tipo = "JerarquiasEmeplo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Muy satisfecho",
                    Tipo = "GradosSatisfaccion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Satisfecho",
                    Tipo = "GradosSatisfaccion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Nada satisfecho",
                    Tipo = "GradosSatisfaccion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Muy inestable",
                    Tipo = "ConsideracionesTrabajo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Inestable",
                    Tipo = "ConsideracionesTrabajo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Estable",
                    Tipo = "ConsideracionesTrabajo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Muy Estable",
                    Tipo = "ConsideracionesTrabajo"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Totalmente relacionado",
                    Tipo = "GradosRelacionProfesion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Mucha relación",
                    Tipo = "GradosRelacionProfesion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Alguna relación",
                    Tipo = "GradosRelacionProfesion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Ninguna relación",
                    Tipo = "GradosRelacionProfesion"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Microempresa",
                    Tipo = "TamañosEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Pequeña empresa",
                    Tipo = "TamañosEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Mediana empresa",
                    Tipo = "TamañosEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Gran empresa",
                    Tipo = "TamañosEmpresa"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Despidieron del empleo y no ha encontrado otro",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Es el único trabajo que ha conseguido hasta el momento",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Se gana más como independiente que como empleado",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "El horario es más flexible",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Por la edad",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 6,
                    Nombre = "Mayor estabilidad o mejor futuro",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 7,
                    Nombre = "Como independiente tiene más posibilidades de progresar",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 8,
                    Nombre = "Quiere tener su propia empresa",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 9,
                    Nombre = "Se tiene menor responsabilidad",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 10,
                    Nombre = "No quiere tener jefe ni que lo manden",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 11,
                    Nombre = "Por tradición familiar",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 12,
                    Nombre = "Heredó el negocio o actividad",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 13,
                    Nombre = "Está acostumbrado a trabajar como independiente",
                    Tipo = "RazonesTrabajoIndependiente"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Por honorarios o prestación de servicios",
                    Tipo = "FormasTrabajoRealizado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Por hora",
                    Tipo = "FormasTrabajoRealizado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Por comisión únicamente",
                    Tipo = "FormasTrabajoRealizado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Vendiendo por catalogo",
                    Tipo = "FormasTrabajoRealizado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Tiene un negocio de industria de comercio, servicios o una finca",
                    Tipo = "FormasTrabajoRealizado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Renuncia voluntaria",
                    Tipo = "MotivosDesvinculacionLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Renuncia involuntaria (despido)",
                    Tipo = "MotivosDesvinculacionLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Terminación de contrato",
                    Tipo = "MotivosDesvinculacionLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Reestructuración de la empresa",
                    Tipo = "MotivosDesvinculacionLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Finalización del contrato",
                    Tipo = "MotivosDesvinculacionLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "1",
                    Tipo = "ValoracionesPercepcionUniversidad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "2",
                    Tipo = "ValoracionesPercepcionUniversidad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "3",
                    Tipo = "ValoracionesPercepcionUniversidad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "4",
                    Tipo = "ValoracionesPercepcionUniversidad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "5",
                    Tipo = "ValoracionesPercepcionUniversidad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Nivel académico",
                    Tipo = "RazonesRecomendarPrograma"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Posibilidades laborales",
                    Tipo = "RazonesRecomendarPrograma"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Perfil profesional",
                    Tipo = "RazonesRecomendarPrograma"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Prestigio de la Universidad",
                    Tipo = "RazonesRecomendarPrograma"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Posibilidad de estudios en el exterior",
                    Tipo = "RazonesRecomendarPrograma"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Ha sido bastante el aporte a mi desempeño profesional",
                    Tipo = "AportesFormacionDesempenioLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Me aporta en cierta medida a mi desempeño profesional",
                    Tipo = "AportesFormacionDesempenioLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Aporta de manera insuficiente a mi desempeño laboral",
                    Tipo = "AportesFormacionDesempenioLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "No me da ningún aporte a mi desempeño laboral",
                    Tipo = "AportesFormacionDesempenioLaboral"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Especialización",
                    Tipo = "EstudiosPostgrado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Maestría",
                    Tipo = "EstudiosPostgrado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Doctorado",
                    Tipo = "EstudiosPostgrado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Ninguno",
                    Tipo = "EstudiosPostgrado"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Desarrollo de competencias básicas. Ingles",
                    Tipo = "AreaCapacitacionesRequeridas"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Comunicaciones",
                    Tipo = "AreaCapacitacionesRequeridas"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Informática (programas especializados) Profesional ¿cuál?",
                    Tipo = "AreaCapacitacionesRequeridas"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Educación continuada ¿cuál?",
                    Tipo = "AreaCapacitacionesRequeridas"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Estudio de posgrado: especialización, maestría, doctorado, ¿cuál?",
                    Tipo = "AreaCapacitacionesRequeridas"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Ninguno",
                    Tipo = "GradosEscolaridad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Primaria",
                    Tipo = "GradosEscolaridad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Secundaria",
                    Tipo = "GradosEscolaridad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Técnico",
                    Tipo = "GradosEscolaridad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 5,
                    Nombre = "Universitario",
                    Tipo = "GradosEscolaridad"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Económica",
                    Tipo = "RazonesTrabajoDuranteEstudio"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Aprovechar el tiempo libre",
                    Tipo = "RazonesTrabajoDuranteEstudio"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Adquirir experiencia",
                    Tipo = "RazonesTrabajoDuranteEstudio"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Inicio del programa",
                    Tipo = "TiemposDuranteEstudio"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Intermedio",
                    Tipo = "TiemposDuranteEstudio"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Final",
                    Tipo = "TiemposDuranteEstudio"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 1,
                    Nombre = "Amplió su experiencia",
                    Tipo = "EfectosTrabajoDuranteEstudios"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 2,
                    Nombre = "Reforzó su preparación",
                    Tipo = "EfectosTrabajoDuranteEstudios"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 3,
                    Nombre = "Limitó su preparación",
                    Tipo = "EfectosTrabajoDuranteEstudios"
                },
                new ParametricosEncuentaIesDTO
                {
                    Id = 4,
                    Nombre = "Otro ¿Cuál?",
                    Tipo = "EfectosTrabajoDuranteEstudios"
                }
            };
        }
    }
}
