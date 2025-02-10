using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Archivo.S3;
using SispeServiciosApiIntermediacion.Aplicacion.Utils;
using SispeServiciosApiIntermediacion.Aplicacion.Validadciones;
using System.Collections.Generic;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Vacante
{
    public class Edicion
    {
        public class Ejecuta : VacanteBaseDTO, IRequest<VacanteNuevoSalidaDTO>
        {
            public Guid Id { get; set; }            
            public string? solicitudAutorizacionExcepcionalidadFilePath { get; set; }            
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion(Contexto contexto)
            {
                RuleFor(x => x.CodigoInternoVacante)
                    .Must((m, CodigoInternoVacante) => { return HidrocarburosValidator.CodigoInternoVacanteUnicoAsync(CodigoInternoVacante, contexto, m.Id).Result; })
                    //.MustAsync(async (x, cancellation) => { return await HidrocarburosValidator.CodigoInternoVacanteUnicoAsync(x, contexto, Guid.NewGuid()); } )
                    .WithMessage(IntermediacionErrors.codigoInternoVacanteUnico);
            }
        }

        public class Manejador : IRequestHandler<Ejecuta, VacanteNuevoSalidaDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;
            private readonly IConfiguration _config;
            private readonly IStorageService _storageService;

            public Manejador(Contexto contexto, IMapper mapper, IStorageService storageService, IConfiguration config)
            {
                _contexto = contexto;
                _mapper = mapper;
                _storageService = storageService;
                _config = config;
            }

            public async Task<VacanteNuevoSalidaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var entidad = await _contexto.Vacantes
                    .Include(i => i.Ubicaciones)
                    .Include(i => i.ConocimientosCompetencias)
                    .Include(i => i.HabilidadesDestrezas)
                    .Include(i => i.DenominacionesRelacionadas)
                    .Include(i => i.MotivosExcepcionalidad)
                    .Include(i => i.Discapacidades)
                    .Include(i => i.Idiomas)
                    .Include(i => i.PrestadoresAlternos)
                    .Include(i => i.ZonasGeograficas)
                    .Include(i => i.PoblacionesVulnerables)
                    .Include(i => i.GruposEtnicos)
                    .Include(i => i.CondicionesSaludMental)
                    .Include(i => i.TiposPoblacion)
                    .Include(i => i.Archivos)
                    .Include(i => i.CambioEstados)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                var modelRequest = _mapper.Map<Ejecuta, VacanteModel>(request);

      
                if (entidad is not null)
                {
                    if (modelRequest.PrestadoresAlternos is not null)
                    {
                        var accion = adicionarEliminarPrestador(entidad.PrestadoresAlternos, request.PrestadoresAlternos);
                        if (accion.prestadorNuevos.Count() > 0)
                        {
                            entidad.PrestadoresAlternos?.AddRange(accion.prestadorNuevos);
                        }

                        if (accion.prestadorEliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(accion.prestadorEliminar);
                        }
                    }

                    if (modelRequest.Idiomas is not null)
                    {
                        var accion = adicionarEliminarIdiomas(entidad.Idiomas ?? new List<VacanteIdiomaModel>(), modelRequest.Idiomas ?? new List<VacanteIdiomaModel>());
                        if (accion.IdiomasNuevos.Count() > 0)
                        {
                            entidad.Idiomas?.AddRange(accion.IdiomasNuevos);
                        }

                        if (accion.IdiomasEditar.Count() > 0)
                        {
                            entidad.Idiomas?.AddRange(accion.IdiomasEditar);
                        }

                        if (accion.IdiomasEliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(accion.IdiomasEliminar);
                        }
                    }


                    if (modelRequest.MotivosExcepcionalidad is not null)
                    {
                        var MotivosModelParametrico = _mapper.Map<List<VacanteMotivoExcepcionalidadModel>, List<int>>(entidad.MotivosExcepcionalidad);
                        var accion = adicionarEliminarParamtericosInt(MotivosModelParametrico, request.MotivosExcepcionalidad);
                        var nuevos = _mapper.Map<List<int>, List<VacanteMotivoExcepcionalidadModel>>(accion.ParametricosNuevos);
                        List<VacanteMotivoExcepcionalidadModel> eliminar = entidad.MotivosExcepcionalidad.Where(x => accion.ParametricosEliminar.Contains(x.MotivosExcepcionalidadId)).ToList();

                        if (nuevos.Count() > 0)
                        {
                            entidad.MotivosExcepcionalidad?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }



                    if (modelRequest.Discapacidades is not null)
                    {
                        var DiscapacidadesModelParametrico = _mapper.Map<List<VacanteDiscapacidadModel>, List<int>>(entidad.Discapacidades);
                        var accion = adicionarEliminarParamtericosInt(DiscapacidadesModelParametrico, request.Discapacidades);
                        var nuevos = _mapper.Map<List<int>, List<VacanteDiscapacidadModel>>(accion.ParametricosNuevos);
                        List<VacanteDiscapacidadModel> eliminar = entidad.Discapacidades.Where(x => accion.ParametricosEliminar.Contains(x.DiscapacidadId)).ToList();

                        if (nuevos.Count() > 0)
                        {
                            entidad.Discapacidades?.AddRange(nuevos);

                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.DenominacionesRelacionadas is not null)
                    {
                        var ocupacionModelParametrico = _mapper.Map<List<VacanteDenominacionRelacionadaModel>, List<string>>(entidad.DenominacionesRelacionadas);
                        var accion = adicionarEliminarParamtericosString(ocupacionModelParametrico, request.DenominacionesRelacionadas);
                        var nuevos = _mapper.Map<List<string>, List<VacanteDenominacionRelacionadaModel>>(accion.ParametricosNuevos);
                        List<VacanteDenominacionRelacionadaModel> eliminar = entidad.DenominacionesRelacionadas.Where(x => accion.ParametricosEliminar.Contains(x.DenominacionRelacionadaId)).ToList();

                        if (nuevos.Count() > 0)
                        {
                            entidad.DenominacionesRelacionadas?.AddRange(nuevos);

                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }
                    //
                    if (modelRequest.ConocimientosCompetencias is not null)
                    {
                        var ocupacionModelParametrico = _mapper.Map<List<VacanteConocimientoCompetenciaModel>, List<string>>(entidad.ConocimientosCompetencias);
                        var accion = adicionarEliminarParamtericosString(ocupacionModelParametrico, request.ConocimientosCompetencias);
                        var nuevos = _mapper.Map<List<string>, List<VacanteConocimientoCompetenciaModel>>(accion.ParametricosNuevos);
                        List<VacanteConocimientoCompetenciaModel> eliminar = entidad.ConocimientosCompetencias.Where(x => accion.ParametricosEliminar.Contains(x.ConocimientoCompetenciaId)).ToList();

                        if (nuevos.Count() > 0)
                        {
                            entidad.ConocimientosCompetencias?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.HabilidadesDestrezas is not null)
                    {
                        var ModelParametrico = _mapper.Map<List<VacanteHabilidadDestrezaModel>, List<string>>(entidad.HabilidadesDestrezas);
                        var accion = adicionarEliminarParamtericosString(ModelParametrico, request.HabilidadesDestrezas);
                        var nuevos = _mapper.Map<List<string>, List<VacanteHabilidadDestrezaModel>>(accion.ParametricosNuevos);
                        List<VacanteHabilidadDestrezaModel> eliminar = entidad.HabilidadesDestrezas.Where(x=> accion.ParametricosEliminar.Contains(x.HabilidadDestrezaId)).ToList();
                        if (nuevos.Count() > 0)
                        {
                            entidad.HabilidadesDestrezas?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.PoblacionesVulnerables is not null)
                    {
                        var ModelParametrico = _mapper.Map<List<VacantePoblacionVulnerableModel>, List<int>>(entidad.PoblacionesVulnerables);
                        var accion = adicionarEliminarParamtericosInt(ModelParametrico, request.PoblacionesVulnerables);
                        var nuevos = _mapper.Map<List<int>, List<VacantePoblacionVulnerableModel>>(accion.ParametricosNuevos);
                        List<VacantePoblacionVulnerableModel> eliminar = entidad.PoblacionesVulnerables.Where(x => accion.ParametricosEliminar.Contains(x.PoblacionVulnerableId)).ToList();
                        if (nuevos.Count() > 0)
                        {
                            entidad.PoblacionesVulnerables?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.GruposEtnicos is not null)
                    {
                        var ModelParametrico = _mapper.Map<List<VacanteGrupoEtnicoModel>, List<int>>(entidad.GruposEtnicos);
                        var accion = adicionarEliminarParamtericosInt(ModelParametrico, request.GruposEtnicos);
                        var nuevos = _mapper.Map<List<int>, List<VacanteGrupoEtnicoModel>>(accion.ParametricosNuevos);
                        List<VacanteGrupoEtnicoModel> eliminar = entidad.GruposEtnicos.Where(x => accion.ParametricosEliminar.Contains(x.GrupoEtnicoId)).ToList();
                        if (nuevos.Count() > 0)
                        {
                            entidad.GruposEtnicos?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.CondicionesSaludMental is not null)
                    {
                        var ModelParametrico = _mapper.Map<List<VacanteCondicionSaludMentalModel>, List<int>>(entidad.CondicionesSaludMental);
                        var accion = adicionarEliminarParamtericosInt(ModelParametrico, request.CondicionesSaludMental);
                        var nuevos = _mapper.Map<List<int>, List<VacanteCondicionSaludMentalModel>>(accion.ParametricosNuevos);
                        List<VacanteCondicionSaludMentalModel> eliminar = entidad.CondicionesSaludMental.Where(x => accion.ParametricosEliminar.Contains(x.CondicionSaludMentalId)).ToList();
                        if (nuevos.Count() > 0)
                        {
                            entidad.CondicionesSaludMental?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.TiposPoblacion is not null)
                    {
                        var ModelParametrico = _mapper.Map<List<VacanteTipoPoblacionModel>, List<int>>(entidad.TiposPoblacion);
                        var accion = adicionarEliminarParamtericosInt(ModelParametrico, request.TiposPoblacion);
                        var nuevos = _mapper.Map<List<int>, List<VacanteTipoPoblacionModel>>(accion.ParametricosNuevos);
                        List<VacanteTipoPoblacionModel> eliminar = entidad.TiposPoblacion.Where(x => accion.ParametricosEliminar.Contains(x.TipoPoblacionId)).ToList();
                        if (nuevos.Count() > 0)
                        {
                            entidad.TiposPoblacion?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.ZonasGeograficas is not null)
                    {
                        var ModelParametrico = _mapper.Map<List<VacanteZonaGeograficaModel>, List<int>>(entidad.ZonasGeograficas);
                        var accion = adicionarEliminarParamtericosInt(ModelParametrico, request.ZonasGeograficas);
                        var nuevos = _mapper.Map<List<int>, List<VacanteZonaGeograficaModel>>(accion.ParametricosNuevos);
                        List<VacanteZonaGeograficaModel> eliminar = entidad.ZonasGeograficas.Where(x => accion.ParametricosEliminar.Contains(x.VacanteZonaGeograficaId)).ToList();
                        if (nuevos.Count() > 0)
                        {
                            entidad.ZonasGeograficas?.AddRange(nuevos);
                        }
                        if (eliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(eliminar);
                        }
                    }

                    if (modelRequest.Ubicaciones is not null)
                    {
                        
                        var accion = adicionarEliminarUbicaciones(entidad.Ubicaciones, modelRequest.Ubicaciones);                       
                        if (accion.UbicacionesNuevos.Count() > 0)
                        {
                            entidad.Ubicaciones?.AddRange(accion.UbicacionesNuevos);
                        }
                        if (accion.UbicacionesEliminar.Count() > 0)
                        {
                            _contexto.RemoveRange(accion.UbicacionesEliminar);
                        }
                    }

                    //si llega archivo
                    if (request.SolicitudAutorizacionExcepcionalidadFile is not null)
                    {
                        var archivoActual =  entidad.Archivos.FirstOrDefault(x=> x.TipoArchivo == "SolicitudAutorizacionExcepcionalidad");
                        var config = new ConfigStorage()
                        {
                            Repository = _config["ConfigStorage:Repository"],
                            SecretKey = _config["ConfigStorage:SecretKey"],
                            AccessKey = _config["ConfigStorage:AccessKey"],
                            File = request.SolicitudAutorizacionExcepcionalidadFile,
                            FileName = $"{entidad.SedeId}-{entidad.Numero}"
                        };

                        var respuestaArchivo = await _storageService.UploadFileAsync(config);

                        //si hay archivo
                        if (archivoActual is not null)
                        {

                            //si archivo actual es diferente a nuevo archivo
                            if (respuestaArchivo.FileNameRespository != archivoActual.NombreArchivoRepositorio)
                            {
                                config.FileName = archivoActual.NombreArchivoRepositorio;
                                await _storageService.DeleteDocument(config);
                            }

                            archivoActual.NombreArchivo = respuestaArchivo.FileName;
                            archivoActual.NombreArchivoRepositorio = respuestaArchivo.FileNameRespository;
                            entidad.Archivos.Add(archivoActual);
                        }
                        else
                        {                            
                            entidad.Archivos.Add(new VacanteArchivoModel()
                            {
                                TipoArchivo = "SolicitudAutorizacionExcepcionalidad",
                                NombreArchivo = respuestaArchivo.FileName,
                                NombreArchivoRepositorio = respuestaArchivo.FileNameRespository,
                            });                            
                        }
                    }
                    else if (request.solicitudAutorizacionExcepcionalidadFilePath is null) {
                        var archivoActual = entidad.Archivos.FirstOrDefault(x => x.TipoArchivo == "SolicitudAutorizacionExcepcionalidad");
                        if(archivoActual is not null)
                        {
                            var config = new ConfigStorage()
                            {
                                Repository = _config["ConfigStorage:Repository"],
                                SecretKey = _config["ConfigStorage:SecretKey"],
                                AccessKey = _config["ConfigStorage:AccessKey"],
                                File = request.SolicitudAutorizacionExcepcionalidadFile,
                                FileName = archivoActual.NombreArchivoRepositorio
                            };
                            var r = await _storageService.DeleteDocument(config);
                            _contexto.Remove(archivoActual);
                        }
                        
                    }

                    if (entidad.EstadoId != request.EstadoId)
                    {
                        entidad.CambioEstados.Add(
                            new VacanteCambioEstadoModel()
                            {
                                EstadoId = request.EstadoId,
                            });
                    }



                    entidad.Identificador = $"{entidad.SedeId}-{entidad.Numero}-{modelRequest.PuestosRequeridos ?? 0}";
                    //_mapper.Map(request, entidad);

                    entidad.Nombre = modelRequest.Nombre;
                    entidad.PuestosRequeridos = modelRequest.PuestosRequeridos;
                    entidad.ModalidadTrabajoId = modelRequest.ModalidadTrabajoId;
                    //entidad.UbicacionId = modelRequest.UbicacionId;
                    entidad.SectorEconomicoId = modelRequest.SectorEconomicoId;
                    entidad.SubsectorEconomicoId = modelRequest.SubsectorEconomicoId;
                    entidad.RequiereViajarPorTrabajo = modelRequest.RequiereViajarPorTrabajo;
                    entidad.TendraPersonasCargo = modelRequest.TendraPersonasCargo;
                    entidad.RequiereLicenciaConduccionCarro = modelRequest.RequiereLicenciaConduccionCarro;
                    entidad.RequiereLicenciaConduccion = modelRequest.RequiereLicenciaConduccion;
                    entidad.CategoriaLicenciaCarroId = modelRequest.CategoriaLicenciaCarroId;
                    entidad.RequiereLicenciaConduccionMoto = modelRequest.RequiereLicenciaConduccionMoto;
                    entidad.CategoriaLicenciaMotoId = modelRequest.CategoriaLicenciaMotoId;
                    entidad.AreaEmpresaId = modelRequest.AreaEmpresaId;
                    entidad.ResponsableId = modelRequest.ResponsableId;
                    entidad.FechaEstimadaOcupacionCargo = modelRequest.FechaEstimadaOcupacionCargo;
                    entidad.FechaVencimientoVacante = modelRequest.FechaVencimientoVacante;
                    entidad.FechaLimiteEnvioHv = modelRequest.FechaLimiteEnvioHv;
                    entidad.Confidencial = modelRequest.Confidencial;
                    entidad.SolicitudExcepcionalidad = modelRequest.SolicitudExcepcionalidad;
                    entidad.SolicitudAutorizacionExcepcionalidad = modelRequest.SolicitudAutorizacionExcepcionalidad; //url-> archivo

                    entidad.AptaParaPersonasConDiscapacidad = modelRequest.AptaParaPersonasConDiscapacidad;
                    entidad.GestionadaPorPrestador = modelRequest.GestionadaPorPrestador;
                    entidad.GestionadaPorPrestadorAlterno = modelRequest.GestionadaPorPrestadorAlterno;
                    //primero

                    entidad.FormacionTitulo = modelRequest.FormacionTitulo;
                    entidad.Graduado = modelRequest.Graduado;
                    entidad.NivelMinimoEstudioId = modelRequest.NivelMinimoEstudioId;
                    entidad.RequiereExperienciaGeneral = modelRequest.RequiereExperienciaGeneral;
                    entidad.TiempoExperiencia = modelRequest.TiempoExperiencia;
                    entidad.RequiereExperienciaEspecifica = modelRequest.RequiereExperienciaEspecifica;
                    entidad.DescripcionExperienciaEspecifica = modelRequest.DescripcionExperienciaEspecifica;
                    entidad.RequiereCapacitacionEspecifica = modelRequest.RequiereCapacitacionEspecifica;
                    entidad.DescripcionCapacitacionEspecifica = modelRequest.DescripcionCapacitacionEspecifica;
                    entidad.RequiereCertificacionEspecifica = modelRequest.RequiereCertificacionEspecifica;
                    entidad.DescripcionCertificacionEspecifica = modelRequest.DescripcionCertificacionEspecifica;
                    entidad.InformacionAdicional = modelRequest.InformacionAdicional;
                    entidad.Descripcion = modelRequest.Descripcion;
                    entidad.TipoContratoId = modelRequest.TipoContratoId;
                    entidad.JornadaLaboralId = modelRequest.JornadaLaboralId;

                    entidad.TipoSalarioId = modelRequest.TipoSalarioId;
                    entidad.RangoSalarialInicial = modelRequest.RangoSalarialInicial;
                    entidad.RangoSalarialFinal = modelRequest.RangoSalarialFinal;
                    entidad.PeriodicidadSalarialId = modelRequest.PeriodicidadSalarialId;


                    entidad.TieneVideoAdjunto = modelRequest.TieneVideoAdjunto;
                    entidad.TipoProyectoId = modelRequest.TipoProyectoId;
                    entidad.CodigoInternoVacante = modelRequest.CodigoInternoVacante;
                    entidad.ManoObraCalificada = modelRequest.ManoObraCalificada;
                    entidad.RangoRemitirCandidatoInicial = modelRequest.RangoRemitirCandidatoInicial;
                    entidad.RangoRemitirCandidatoFinal = modelRequest.RangoRemitirCandidatoFinal;
                    entidad.PriorizarZonaRural = modelRequest.PriorizarZonaRural;
                    entidad.PriorizarPoblacionVulnerable = modelRequest.PriorizarPoblacionVulnerable;
                    entidad.PerteneceARural = modelRequest.PerteneceARural;
                    entidad.RegistroVacanteDemasPrestadores = modelRequest.RegistroVacanteDemasPrestadores;



                    entidad.VisibilidadSalario = modelRequest.VisibilidadSalario;
                    entidad.CompensacionAdicional = modelRequest.CompensacionAdicional;
                    entidad.DescripcionCompensacionAdicional = modelRequest.DescripcionCompensacionAdicional;
                    entidad.VideoUrl = modelRequest.VideoUrl;  //url video
                    entidad.VideoDescripcion = modelRequest.VideoDescripcion;
                    entidad.EstadoId = modelRequest.EstadoId;
                    entidad.NombreZonaGeografica = modelRequest.NombreZonaGeografica;
                    entidad.EsHidrocarburos = EsHidrocarburos.validar(entidad);

                    _contexto.Vacantes.Update(entidad);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return new VacanteNuevoSalidaDTO() { Id = entidad.Id, Identificador = entidad.Identificador };
                    }
                    throw new Exception("Error al gurdar.");
                }
                throw new Exception("No existe Vacante.");
            }
            private (List<VacantePrestadorAlternoModel> prestadorEliminar, List<VacantePrestadorAlternoModel> prestadorNuevos) adicionarEliminarPrestador(List<VacantePrestadorAlternoModel> prestadorActuales, List<Guid>? PrestadorRequest)//
            {
                var prestadorNuevos = new List<VacantePrestadorAlternoModel>();
                var prestadorEliminar = new List<VacantePrestadorAlternoModel>();
                var prestadorEditar = new List<VacantePrestadorAlternoModel>();
                PrestadorRequest?.ForEach((x) =>
                {
                    var existe = prestadorActuales.Find(f => f.PrestadorId == x);
                    if (existe is null)
                    {
                        prestadorNuevos.Add(new VacantePrestadorAlternoModel() { PrestadorId = x });
                    }
                    else
                    {
                        prestadorEditar.Add(new VacantePrestadorAlternoModel() { PrestadorId = x });
                    }
                });

                prestadorActuales.ForEach(x =>
                {
                    var existe = prestadorEditar.FindAll(f => f.PrestadorId == x.PrestadorId).Count();
                    if (existe == 0)
                    {
                        prestadorEliminar.Add(x);
                    }
                });
                return (prestadorEliminar, prestadorNuevos);
            }


            private (List<VacanteIdiomaModel> IdiomasEliminar, List<VacanteIdiomaModel> IdiomasNuevos, List<VacanteIdiomaModel> IdiomasEditar) adicionarEliminarIdiomas(List<VacanteIdiomaModel> IdiomasActuales, List<VacanteIdiomaModel> IdiomasRequest)//
            {
                var IdiomasNuevos = new List<VacanteIdiomaModel>();
                var IdiomasEliminar = new List<VacanteIdiomaModel>();
                var IdiomasEditar = new List<VacanteIdiomaModel>();
                IdiomasRequest.ForEach((x) =>
                {
                    var existe = IdiomasActuales.Find(f => f.IdiomaId == x.IdiomaId);
                    if (existe is null)
                    {
                        IdiomasNuevos.Add(x);
                    }
                    else
                    {
                        existe.NivelEscrituraId = x.NivelEscrituraId;
                        existe.NivelLecturaId = x.NivelLecturaId;
                        existe.NivelConversacionalId = x.NivelConversacionalId;
                        existe.NivelEscuchaId = x.NivelEscuchaId;
                        IdiomasEditar.Add(existe);
                    }
                });

                IdiomasActuales.ForEach(x =>
                {
                    var existe = IdiomasEditar.FindAll(f => f.IdiomaId == x.IdiomaId).Count();
                    if (existe == 0)
                    {
                        IdiomasEliminar.Add(x);
                    }
                });
                return (IdiomasEliminar, IdiomasNuevos, IdiomasEditar);
            }


            private (List<VacanteUbicacionModel> UbicacionesEliminar, List<VacanteUbicacionModel> UbicacionesNuevos, List<VacanteUbicacionModel> UbicacionesEditar) adicionarEliminarUbicaciones(List<VacanteUbicacionModel> UbicacionesActuales, List<VacanteUbicacionModel> UbicacionesRequest)//
            {
                var UbicacionesNuevos = new List<VacanteUbicacionModel>();
                var UbicacionesEliminar = new List<VacanteUbicacionModel>();
                var UbicacionesEditar = new List<VacanteUbicacionModel>();
                UbicacionesRequest.ForEach((x) =>
                {
                    var existe = UbicacionesActuales.Find(f => f.DepartamentoId == x.DepartamentoId && f.MunicipioId == x.MunicipioId && f.LocalidadComunaId == x.LocalidadComunaId && f.NumeroPuestos == x.NumeroPuestos);
                    if (existe is null)
                    {
                        UbicacionesNuevos.Add(x);
                    }
                    else
                    {
                        UbicacionesEditar.Add(existe);
                    }
                });

                UbicacionesActuales.ForEach(x =>
                {
                    var existe = UbicacionesEditar.FindAll(f=> f.DepartamentoId == x.DepartamentoId && f.MunicipioId == x.MunicipioId && f.LocalidadComunaId == x.LocalidadComunaId && f.NumeroPuestos == x.NumeroPuestos).Count();
                    if (existe == 0)
                    {
                        UbicacionesEliminar.Add(x);
                    }
                });
                return (UbicacionesEliminar, UbicacionesNuevos, UbicacionesEditar);
            }


            private (List<int> ParametricosEliminar, List<int> ParametricosNuevos, List<int> ParametrciosEditar) adicionarEliminarParamtericosInt(List<int> ParamtericosActuales, List<int>? ParametrciosRequest)//
            {
                var ParametricosNuevos = new List<int>();
                var ParametricosEliminar = new List<int>();
                var ParametrciosEditar = new List<int>();
                ParametrciosRequest?.ForEach((x) =>
                {
                    var existe = ParamtericosActuales.Find(f => f == x);
                    if (existe == 0)
                    {
                        ParametricosNuevos.Add(x);
                    }
                    else
                    {
                        ParametrciosEditar.Add(existe);
                    }
                });

                ParamtericosActuales.ForEach(x =>
                {
                    var existe = ParametrciosEditar.Find(f => f == x);
                    if (existe == 0)
                    {
                        ParametricosEliminar.Add(x);
                    }
                });
                return (ParametricosEliminar, ParametricosNuevos, ParametrciosEditar);
            }

            private (List<string> ParametricosEliminar, List<string> ParametricosNuevos, List<string> ParametrciosEditar) adicionarEliminarParamtericosString(List<string> ParamtericosActuales, List<string>? ParametrciosRequest)//
            {
                var ParametricosNuevos = new List<string>();
                var ParametricosEliminar = new List<string>();
                var ParametrciosEditar = new List<string>();
                ParametrciosRequest?.ForEach((x) =>
                {
                    var existe = ParamtericosActuales.Find(f => f == x);
                    if (existe is null)
                    {
                        ParametricosNuevos.Add(x);
                    }
                    else
                    {
                        ParametrciosEditar.Add(x);
                    }
                });

                ParamtericosActuales.ForEach(x =>
                {
                    var existe = ParametrciosEditar.Find(f => f == x);
                    if (existe is null)
                    {
                        ParametricosEliminar.Add(x);
                    }
                });
                return (ParametricosEliminar, ParametricosNuevos, ParametrciosEditar);
            }


        }
    }
}
