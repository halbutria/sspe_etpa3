using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Helpers;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;
using SispeServicios.Api.Ciudadano.RemoteService;
using SispeServiciosApiCiudadano.Aplicacion.Utils;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class Edicion
    {
        public class Ejecuta : IRequest<CiudadanoInfoDTO>
        {
            public Guid Id { get; set; }
            public Guid UsuarioId { get; set; }
            public int TipoDocumentoId { get; set; }
            public string NumeroDocumento { get; set; }
            public string CorreoElectronico { get; set; }
            public string PrimerNombre { get; set; }
            public string? SegundoNombre { get; set; }
            public string PrimerApellido { get; set; }
            public string? SegundoApellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public int SexoId { get; set; }
            public string Telefono { get; set; }
            public string DireccionResidencia { get; set; }
            public int PaisResidenciaId { get; set; }
            public string? DepartamentoResidenciaId { get; set; }
            public string? MunicipioResidenciaId { get; set; }
            public string PrestadorPreferenciaId { get; set; }
            public string PuntoAtencionId { get; set; }
            public float? PorcentajeHv { get; set; }
            public float? PorcentajeInfoPersonal { get; set; }
            public float? PorcentajeEduFormal { get; set; }
            public float? PorcentajeInfoLaboral { get; set; }
            public float? PorcentajeEduNoFormal { get; set; }
            // opcionales
            public int? EstadoCivilId { get; set; }
            public int? PaisNacimientoId { get; set; }
            public bool? TieneLibretaMilitar { get; set; }
            public int? TipoLibretaMilitarId { get; set; }
            public string? NumeroLibretaMiltar { get; set; }
            public string? DepartamentoNacimientoId { get; set; }
            public string? MunicipioNacimientoId { get; set; }
            public int? NacionalidadId { get; set; }
            public bool? JefeHogar { get; set; }
            public bool? PoblacionFocalizada { get; set; }
            public bool? Sisben { get; set; }
            public int? EpsId { get; set; }
            public string? BarrioResidencia { get; set; }
            public bool? PerteneceARural { get; set; }
            public string? OtroTelefono { get; set; }
            public string? Observacion { get; set; }
            public int? RangoSalarialId { get; set; }
            public int? Estrato { get; set; }
            public string? PerfilLaboral { get; set; }
            public bool? PosibilidadViajar { get; set; }
            public bool? PosibilidadTrasladarse { get; set; }
            public bool? InteresOfertasTeletrabajo { get; set; }
            public int? SituacionLaboralActualId { get; set; }
            public bool? PropiedadMedioTransporte { get; set; }
            public bool? TieneLicenciaConduccionCarro { get; set; }
            public int? CategoriaLicenciaCarroId { get; set; }
            public bool? TieneLicenciaConduccionMoto { get; set; }
            public int? CategoriaLicenciaMotoId { get; set; }
            public int? LocalidadComunaId { get; set; }
            public bool? DispuestoDesplazarseDiariamente { get; set; }
            public bool? DispuestoCambiarMunicipio { get; set; }
            public int? GeneroId { get; set; }
            public string? CualGenero { get; set; }
            public int? OrientacionSexualId { get; set; }
            public string? CualOrientacionSexual { get; set; }
            //public int[]? TipoNotificacion { get; set; }
            public string[] CargoIneteres { get; set; }

            public int? TipoDocumentoAdicionalId { get; set; }
            public string? NumeroDocumentoAdicional { get; set; }
            public int? EstadoCiudadanoId { get; set; }
            public string? CodigoPostal { get; set; }
            public DateTime? FechaExpedicionDocumento { get; set; }
            public string? Estado { get; set; }
            public string? Ciudad { get; set; }
            public string? EstadoNacimiento { get; set; }
            public string? CiudadNacimiento { get; set; }
            public bool? CertificadoResidencia { get; set; }

            // Direccion 
            public List<DireccionDTO>? Direcciones { get; set; }
            public int[]? CondicionDiscapacidad { get; set; }
            public int[]? CondicionSaludMental { get; set; }
            public int[]? TipoPoblacion { get; set; }
            public int[]? GrupoEtnico { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoInfoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IUsuarioService _usuarioService;
            private readonly IMapper _mapper;
            private readonly IMediator _mediator;
            private readonly IDomainEventHub<SendQueueEvent> SendQueueEventHub;

            public Manejador(Contexto contexto, IUsuarioService usuarioService, IMapper mapper, IMediator mediator, IDomainEventHub<SendQueueEvent> sendQueueEventHub)
            {
                _contexto = contexto;
                _usuarioService = usuarioService;
                _mapper = mapper;
                _mediator = mediator;
                SendQueueEventHub = sendQueueEventHub;
            }

            public class EjecutaValidacion : AbstractValidator<Ejecuta>
            {
                private readonly IHttpClientFactory _httpClient;

                public EjecutaValidacion(IHttpClientFactory httpClient, ILogger<UsuarioService> logger)
                {
                    _httpClient = httpClient;


                    //RuleFor(x => x.TipoDocumentoId).NotEmpty();
                    //RuleFor(x => x.NumeroDocumento).NotEmpty();
                    //RuleFor(x => x.CorreoElectronico).NotEmpty().EmailAddress();
                    //RuleFor(x => x.PrimerNombre).NotEmpty();
                    ////RuleFor(x => x.SegundoNombre).NotEmpty(); 
                    //RuleFor(x => x.PrimerApellido).NotEmpty();
                    ////RuleFor(x => x.SegundoApellido).NotEmpty(); 
                    //RuleFor(x => x.FechaNacimiento).NotEmpty();
                    //RuleFor(x => x.SexoId).NotEmpty();
                    //RuleFor(x => x.Telefono).NotEmpty();
                    //RuleFor(x => x.DireccionResidencia).NotEmpty();
                    //RuleFor(x => x.PaisResidenciaId).NotEmpty();
                    //RuleFor(x => x.DepartamentoResidenciaId).NotEmpty();
                    //RuleFor(x => x.MunicipioResidenciaId).NotEmpty();
                    //RuleFor(x => x.PrestadorPreferenciaId).NotEmpty();
                    //RuleFor(x => x.PuntoAtencionId).NotEmpty();
                    //RuleFor(x => x.PreguntaSeguridadId).NotEmpty();
                    //RuleFor(x => x.PreguntaSeguridadRespuesta).NotEmpty();

                    //validacion remotade usuario
                    //RuleFor(x => x.tipoDocumento).MustAsync(async (id, cancellation) => {
                    //    var cliente = _httpClient.CreateClient("Usuarios");
                    //    var response = await cliente.GetAsync("api/usuario/crear");
                    //    return response.IsSuccessStatusCode;
                    //}).WithMessage("ID Must be unique");
                }
            }

            public async Task<CiudadanoInfoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {


                var remote = _mapper.Map<UsuarioRemote>(request);
                remote = UsuarioRemotoConvert.Usuario(remote, request, false);
                var usuario = await _usuarioService.ActualizarUsuario(remote);

                var ciudadano = await _contexto.Ciudadano
                    .Include(i => i.TipoNotificacion)
                    .Include(i => i.CargoInteres)
                    .Include("Direcciones.DireccionComplemento")
                    .Include(i => i.Discapacidad)
                    .Include(i => i.CondicionMental)
                    .Include(i => i.TipoPoblacion)
                    .Include(i => i.GrupoEtnico)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();


                var ciudadanoAntes = Cloner.DeepClone(ciudadano);

                //var ciudadano = await _contexto.Ciudadano.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (ciudadano is not null)
                {
                    var tipoNotificacionAnterior = ciudadano.TipoNotificacion?.ToList();
                    var cargoInteresAnterior = ciudadano.CargoInteres?.ToList();
                    var discapacidadAnterior = ciudadano.Discapacidad?.ToList();
                    var condicionMentalAnterior = ciudadano.CondicionMental?.ToList();
                    var tipoPoblacionAnterior = ciudadano.TipoPoblacion?.ToList();
                    var grupoEtnicoAnterior = ciudadano.GrupoEtnico?.ToList();
                    //var direccionesAnterior = ciudadano.Direccion?.ToList();
                    ICollection<CiudadanoTipoNotificacionModel> tipoNotificacion = new List<CiudadanoTipoNotificacionModel>();
                    ICollection<CiudadanoCargoInteresModel> cargoInteres = new List<CiudadanoCargoInteresModel>();
                    ICollection<CiudadanoDiscapacidadesModel> discapacidad = new List<CiudadanoDiscapacidadesModel>();
                    ICollection<CiudadanoCondicionMentalModel> condicionMental = new List<CiudadanoCondicionMentalModel>();
                    ICollection<CiudadanoTipoPoblacionModel> tipoPoblacion = new List<CiudadanoTipoPoblacionModel>();
                    ICollection<CiudadanoGrupoEtnicoModel> grupoEtnico = new List<CiudadanoGrupoEtnicoModel>();
                    //ICollection<CiudadanoDireccionModel> direcciones = new List<CiudadanoDireccionModel>();

                    foreach (var item in request.CargoIneteres.GroupBy(x => x))
                    {
                        cargoInteres.Add(new CiudadanoCargoInteresModel { CargoInteresId = item.Key });
                    }

                    if (request.CondicionDiscapacidad is not null)
                    {
                        foreach (var id in request.CondicionDiscapacidad)
                            discapacidad.Add(new CiudadanoDiscapacidadesModel { DisacapacidaId = id });
                    }

                    if (request.CondicionSaludMental is not null)
                    {
                        foreach (var id in request.CondicionSaludMental)
                            condicionMental.Add(new CiudadanoCondicionMentalModel { CondicionMentalId = id });
                    }

                    if (request.TipoPoblacion is not null)
                    {
                        foreach (var id in request.TipoPoblacion)
                            tipoPoblacion.Add(new CiudadanoTipoPoblacionModel { TipoPoblacionId = id });
                    }

                    if (request.GrupoEtnico is not null)
                    {
                        foreach (var id in request.GrupoEtnico)
                            grupoEtnico.Add(new CiudadanoGrupoEtnicoModel { GrupoEtnicoId = id });
                    }
                    /*foreach (var id in request.TipoNotificacion)
                    {
                        tipoNotificacion.Add(new CiudadanoTipoNotificacionModel { tipoNotificacionId = id });
                    }*/

                    ciudadano.TipoDocumentoId = request.TipoDocumentoId;
                    ciudadano.NumeroDocumento = request.NumeroDocumento;
                    ciudadano.CorreoElectronico = request.CorreoElectronico;
                    ciudadano.PrimerNombre = request.PrimerNombre;

                    ciudadano.DispuestoDesplazarseDiariamente = request.DispuestoDesplazarseDiariamente;
                    ciudadano.DispuestoCambiarMunicipio = request.DispuestoCambiarMunicipio;


                    ciudadano.SegundoNombre = request.SegundoNombre;
                    ciudadano.PrimerApellido = request.PrimerApellido;
                    ciudadano.SegundoApellido = request.SegundoApellido;
                    ciudadano.FechaNacimiento = request.FechaNacimiento;
                    ciudadano.SexoId = request.SexoId;


                    ciudadano.GeneroId = request.GeneroId;
                    ciudadano.CualGenero = request.CualGenero;
                    ciudadano.OrientacionSexualId = request.OrientacionSexualId;
                    ciudadano.CualOrientacionSexual = request.CualOrientacionSexual;
                    ciudadano.LocalidadComunaId = request.LocalidadComunaId;

                    ciudadano.Telefono = request.Telefono;
                    ciudadano.DireccionResidencia = request.DireccionResidencia;
                    ciudadano.PaisResidenciaId = request.PaisResidenciaId;
                    ciudadano.DepartamentoResidenciaId = request.DepartamentoResidenciaId;
                    ciudadano.MunicipioResidenciaId = request.MunicipioResidenciaId;
                    ciudadano.PrestadorPreferenciaId = request.PrestadorPreferenciaId;
                    ciudadano.PuntoAtencionId = request.PuntoAtencionId;
                    ciudadano.EstadoCivilId = request.EstadoCivilId;
                    ciudadano.PaisNacimientoId = request.PaisNacimientoId;

                    ciudadano.TieneLibretaMilitar = request.TieneLibretaMilitar;
                    ciudadano.TipoLibretaMilitarId = request.TipoLibretaMilitarId;
                    ciudadano.NumeroLibretaMiltar = request.NumeroLibretaMiltar;
                    ciudadano.DepartamentoNacimientoId = request.DepartamentoNacimientoId;
                    ciudadano.MunicipioNacimientoId = request.MunicipioNacimientoId;
                    ciudadano.NacionalidadId = request.NacionalidadId;
                    ciudadano.JefeHogar = request.JefeHogar;
                    ciudadano.PoblacionFocalizada = request.PoblacionFocalizada;
                    ciudadano.Sisben = request.Sisben;
                    ciudadano.EpsId = request.EpsId;
                    ciudadano.BarrioResidencia = request.BarrioResidencia;
                    ciudadano.PerteneceARural = request.PerteneceARural;
                    ciudadano.OtroTelefono = request.OtroTelefono;
                    ciudadano.Observacion = request.Observacion;
                    ciudadano.RangoSalarialId = request.RangoSalarialId;
                    ciudadano.Estrato = request.Estrato;
                    ciudadano.PerfilLaboral = request.PerfilLaboral;
                    ciudadano.PosibilidadViajar = request.PosibilidadViajar;
                    ciudadano.PosibilidadTrasladarse = request.PosibilidadTrasladarse;
                    ciudadano.InteresOfertasTeletrabajo = request.InteresOfertasTeletrabajo;
                    ciudadano.SituacionLaboralActualId = request.SituacionLaboralActualId;
                    ciudadano.PropiedadMedioTransporte = request.PropiedadMedioTransporte;
                    ciudadano.TieneLicenciaConduccionCarro = request.TieneLicenciaConduccionCarro;
                    ciudadano.CategoriaLicenciaCarroId = request.CategoriaLicenciaCarroId;
                    ciudadano.TieneLicenciaConduccionMoto = request.TieneLicenciaConduccionMoto;
                    ciudadano.CategoriaLicenciaMotoId = request.CategoriaLicenciaMotoId;
                    ciudadano.TipoNotificacion = tipoNotificacion;
                    ciudadano.CargoInteres = cargoInteres;

                    ciudadano.CondicionMental = condicionMental;
                    ciudadano.Discapacidad = discapacidad;
                    ciudadano.TipoPoblacion = tipoPoblacion;
                    ciudadano.GrupoEtnico = grupoEtnico;

                    ciudadano.NumeroDocumentoAdicional = request.NumeroDocumentoAdicional;
                    ciudadano.TipoDocumentoAdicionalId = request.TipoDocumentoAdicionalId;
                    ciudadano.EstadoCiudadanoId = request.EstadoCiudadanoId;
                    ciudadano.CodigoPostal = request.CodigoPostal;

                    ciudadano.FechaExpedicionDocumento = request.FechaExpedicionDocumento;
                    ciudadano.Estado = request.Estado;
                    ciudadano.Ciudad = request.Ciudad;
                    ciudadano.EstadoNacimiento = request.EstadoNacimiento;
                    ciudadano.CiudadNacimiento = request.CiudadNacimiento;
                    ciudadano.CertificadoResidencia = request.CertificadoResidencia;

                    var avance = await CalculoAvanceHojaVida.procesarAsync(_contexto, ciudadano, "Información personal");
                    ciudadano.PorcentajeInfoPersonal = avance.Avance;
                    ciudadano.PorcentajeHv = avance.AvanceTotal;
                    ciudadano.HojaVidaCompleta = avance.HojaVidaCompleta;

                    //var respuesta = await _contexto.SaveChangesAsync();

                    //var direccion = await _contexto.CiudadanoDireccion.Where(x => x.CiudadanoId == request.Id).ToListAsync();
                    _contexto.RemoveRange(ciudadano.Direcciones);

                    foreach (var dir in request.Direcciones)
                    {
                        List<CiudadanoDireccionComplementoModel> complemento = new List<CiudadanoDireccionComplementoModel>();
                        if (dir.DireccionComplemento is not null)
                        {
                            foreach (var cmp in dir.DireccionComplemento)
                            {
                                complemento.Add(new CiudadanoDireccionComplementoModel()
                                {
                                    ComplementoId = cmp.ComplementoId,
                                    ComplementoNombre = cmp.ComplementoNombre,
                                    Complemento = cmp.Complemento
                                });
                            }
                        }


                        ciudadano.Direcciones.Add(
                            new CiudadanoDireccionModel
                            {
                                CiudadanoId = (Guid)dir.CiudadanoId,
                                ViaPrincipalId = dir.ViaPrincipalId,
                                ViaPrincipalNombre = dir.ViaPrincipalNombre,
                                ViaPrincipal = dir.ViaPrincipal,
                                ViaPrincipalLetraId = dir.ViaPrincipalLetraId,
                                ViaPrincipalLetraNombre = dir.ViaPrincipalLetraNombre,
                                ViaPrincipalBisId = dir.ViaPrincipalBisId,
                                ViaPrincipalBisNombre = dir.ViaPrincipalBisNombre,
                                ViaPrincipalSegundaLetraId = dir.ViaPrincipalSegundaLetraId,
                                ViaPrincipalSegundaLetraNombre = dir.ViaPrincipalSegundaLetraNombre,
                                ViaPrincipalCuadranteId = dir.ViaPrincipalCuadranteId,
                                ViaPrincipalCuadranteNombre = dir.ViaPrincipalCuadranteNombre,
                                ViaGeneradora = dir.ViaGeneradora,
                                ViaGeneradoraLetraId = dir.ViaGeneradoraLetraId,
                                ViaGeneralLetraNombre = dir.ViaGeneralLetraNombre,
                                ViaGeneradoraPlaca = dir.ViaGeneradoraPlaca,
                                ViaGeneradoraCuadranteId = dir.ViaGeneradoraCuadranteId,
                                ViaGeneradoraCuadranteNombre = dir.ViaGeneradoraCuadranteNombre,
                                DireccionComplemento = complemento

                            });

                        //var complemento = await _contexto.CiudadanoDireccionComplemento.Where(x => x.CiudadanoDireccionId == dir.Id).ToListAsync();
                        //_contexto.CiudadanoDireccionComplemento.RemoveRange(complemento);

                        //foreach (var com in dir.Complementos)
                        //{
                        //    _contexto.CiudadanoDireccionComplemento.Add(
                        //        new CiudadanoDireccionComplementoModel
                        //        { 
                        //            CiudadanoDireccionId = (Guid)com.DireccionId,
                        //            ComplementoId = com.ComplementoId,
                        //            ComplementoNombre = com.ComplementoNombre,
                        //            Complemento = com.Complemento
                        //        }
                        //    );
                        //}



                        //_contexto.CiudadanoDireccion.Update(direccion);
                        //_contexto.CiudadanoTipoNotificacion.RemoveRange(tipoNotificacionAnterior);
                        //_contexto.CiudadanoCargoInteres.RemoveRange(cargoInteresAnterior);
                        //respuesta = await _contexto.SaveChangesAsync();

                    }

                    try
                    {
                        _contexto.Ciudadano.Update(ciudadano);
                        _contexto.CiudadanoTipoNotificacion.RemoveRange(tipoNotificacionAnterior);
                        _contexto.CiudadanoCargoInteres.RemoveRange(cargoInteresAnterior);
                        if (discapacidadAnterior is not null) _contexto.CiudadanoDiscapacidad.RemoveRange(discapacidadAnterior);
                        if (condicionMentalAnterior is not null) _contexto.CiudadanoCondicionMental.RemoveRange(condicionMentalAnterior);
                        if (tipoPoblacionAnterior is not null) _contexto.CiudadanoTipoPoblacion.RemoveRange(tipoPoblacionAnterior);
                        if (grupoEtnicoAnterior is not null) _contexto.CiudadanoGrupoEtnico.RemoveRange(grupoEtnicoAnterior);

                        var respuesta = await _contexto.SaveChangesAsync();

                        if (respuesta > 0)
                        {
                            var resp = _mapper.Map<CiudadanoModel, CiudadanoInfoDTO>(ciudadano);
                            resp.CargoIneteres = _mapper.Map<ICollection<CiudadanoCargoInteresModel>, List<string>>(ciudadano.CargoInteres);
                            resp.GrupoEtnico = _mapper.Map<ICollection<CiudadanoGrupoEtnicoModel>, List<int>>(ciudadano.GrupoEtnico);
                            resp.CondicionDiscapacidad = _mapper.Map<ICollection<CiudadanoDiscapacidadesModel>, List<int>>(ciudadano.Discapacidad);
                            resp.CondicionSaludMental = _mapper.Map<ICollection<CiudadanoCondicionMentalModel>, List<int>>(ciudadano.CondicionMental);
                            resp.TipoPoblacion = _mapper.Map<ICollection<CiudadanoTipoPoblacionModel>, List<int>>(ciudadano.TipoPoblacion);

                            var ciudadanoDespues = await _contexto.Ciudadano
                               .Include(i => i.TipoNotificacion)
                               .Include(i => i.CargoInteres)
                               .Include("Direcciones.DireccionComplemento")
                               .Include(i => i.Discapacidad)
                               .Include(i => i.CondicionMental)
                               .Include(i => i.TipoPoblacion)
                               .Include(i => i.GrupoEtnico)
                               .Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                            RaiseEventItIsSuccess(ciudadanoAntes, resp, ciudadanoDespues);

                            return await _mediator.Send(new Consulta.Ejecuta { Id = resp.Id });
                        }

                        throw new Exception("Error al gurdar el Ciudadano");
                    }
                    catch (Exception e)
                    {

                        throw new Exception(e.Message);
                    }

                }



                throw new Exception("No existe Ciudadano.");
            }

            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoModel ciudadano, CiudadanoInfoDTO ciudadanoReq, CiudadanoModel ciudadanoDespues)
            {
                var (diference, snPrincipalChange) = ExternalRequestMapper.GetDifferences(ciudadano, ciudadanoReq, ciudadanoDespues, ReportFields.ParentFields);


                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.Id.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = diference
                };


                if (snPrincipalChange)
                {
                    message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                    {
                        Tabla = "Ciudadano",
                        Registro = new RegistroDto
                        {
                            Id = ciudadano.Id.ToString(),
                            Proceso = "Actualizacion"
                        }

                    });
                }
                if (message.ExternalRequestBodyDto.Any())
                    SendQueueEventHub.Raise(message);
            }


        }

    }
}
