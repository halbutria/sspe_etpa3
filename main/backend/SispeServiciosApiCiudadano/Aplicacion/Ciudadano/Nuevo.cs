using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;
using SispeServicios.Api.Ciudadano.RemoteService;
using SispeServiciosApiCiudadano.Aplicacion.Utils;
using SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<CiudadanoInfoDTO>
        {
            public int TipoDocumentoId { get; set; }
            public string NumeroDocumento { get; set; }
            public string CorreoElectronico { get; set; }
            public string PrimerNombre { get; set; }
            public string? SegundoNombre { get; set; }
            public string PrimerApellido { get; set; }
            public string? SegundoApellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public int SexoId { get; set; }
            public string DireccionResidencia { get; set; }
            //public string? PaisResidenciaId { get; set; }
            public int PaisResidenciaId { get; set; }
            public string? DepartamentoResidenciaId { get; set; }
            public string? MunicipioResidenciaId { get; set; }
            public string PrestadorPreferenciaId { get; set; }
            public string PuntoAtencionId { get; set; }
            public int PreguntaSeguridadId { get; set; }
            public string PreguntaSeguridadRespuesta { get; set; }
            public bool TerminosCondiciones { get; set; }
            public bool TratamientoDatosPersonales { get; set; }
            public string Password { get; set; }
            public string? CodigoPostal { get; set; }
            public string? PreguntaLibre { get; set; }
            public int? LocalidadComunaId { get; set; }
            public string? BarrioResidencia { get; set; }
            public bool? PerteneceARural { get; set; }

            public int[] TipoNotificacion { get; set; }

            public int? TipoDocumentoAdicional { get; set; }
            public string? NumeroDocumentoAdicional { get; set; }
            public bool? TieneLibretaMilitar { get; set; }
            public int? TipoLibretaMilitar { get; set; }
            public string? NumeroLibretaMiltar { get; set; }
            public string? Telefono { get; set; }
            public string? OtroTelefono { get; set; }

            public DateTime? FechaExpedicionDocumento { get; set; }
            public string? Estado { get; set; }
            public string? Ciudad { get; set; }
            public string? EstadoNacimiento { get; set; }
            public string? CiudadNacimiento { get; set; }
            public bool Autorregistro { get; set; } = true;

            public List<DireccionDTO>? Direcciones { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion(ILogger<UsuarioService> logger, IParametricoService parametricoService) //, IHttpClientFactory httpClient
            {

                //RuleFor(x => x.NumeroDocumento).NotEmpty();
                //RuleFor(x => new { x.TipoDocumentoId, x.NumeroDocumento }).Must(x => NumeroDocumentoValidator.Valid(x.TipoDocumentoId, x.NumeroDocumento)).WithMessage(CiudadanosErrors.cedeulaNumeroError);
                //RuleFor(x => x.TipoDocumentoId).NotEmpty();
                //RuleFor(x => x.CorreoElectronico).NotEmpty().EmailAddress();
                //RuleFor(x => x.PrimerNombre).NotEmpty();
                ////RuleFor(x => x.SegundoNombre).NotEmpty(); 
                //RuleFor(x => x.PrimerApellido).NotEmpty();
                ////RuleFor(x => x.SegundoApellido).NotEmpty(); 
                //RuleFor(x => x.FechaNacimiento).NotEmpty();
                //RuleFor(x => x.GeneroId).NotEmpty();
                //RuleFor(x => x.Telefono).NotEmpty();
                //RuleFor(x => x.DireccionResidencia).NotEmpty();
                //RuleFor(x => x.PaisResidenciaId).NotEmpty();
                //RuleFor(x => x.DepartamentoId).NotEmpty();
                //RuleFor(x => x.MunicipioId).NotEmpty();
                //RuleFor(x => x.PrestadorPreferenciaId).NotEmpty();
                //RuleFor(x => x.PuntoAtencionId).NotEmpty();
                //RuleFor(x => x.PreguntaSeguridadId).NotEmpty();
                //RuleFor(x => x.PreguntaSeguridadRespuesta).NotEmpty();
                //RuleFor(x => x.TerminosCondiciones).NotEmpty();
                //RuleFor(x => x.TratamientoDatosPersonales).NotEmpty();
                //RuleFor(x => x.Password).NotEmpty();

                //RuleFor(x => x.PorcentajeHv).NotEmpty();
                //RuleFor(x => x.PorcentajeInfoPersonal).NotEmpty();
                //RuleFor(x => x.PorcentajeEduFormal).NotEmpty();
                //RuleFor(x => x.PorcentajeInfoLaboral).NotEmpty();
                //RuleFor(x => x.PorcentajeEduNoFormal).NotEmpty();

                //pararevisarlos validar petcion asyc
                //https://medium.com/cheranga/using-asynchronous-fluent-validations-in-asp-net-api-831710b0b9cd
                //RuleFor(x => x.TipoDocumentoId).Must(x => ParametricoValidator.ValidAsync(x.ToString(), "TipoDocumento", parametricoService).Result).WithMessage(CiudadanosErrors.TipoDocuementoNoValidoError);
                //RuleFor(x => x.DepartamentoId).Must(x => ParametricoValidator.ValidAsync(x, "Departamento", parametricoService).Result).WithMessage(CiudadanosErrors.DepartamentoNoValidoError);
                //RuleFor(x => new { id = x.MunicipioId, deprtamentoId = x.DepartamentoId }).Must(x => ParametricoValidator.ValidAsync(x.id, "Municipio", parametricoService, x.deprtamentoId).Result).WithMessage(CiudadanosErrors.MunicipioNoValidoError);
            }
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoInfoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IUsuarioService _usuarioService;
            private readonly IMapper _mapper;
            private readonly IEmailService _email;
            private readonly IDomainEventHub<SendQueueEvent> SendQueueEventHub;

            public Manejador(Contexto contexto, IUsuarioService usuarioService, IMapper mapper, IEmailService email, IDomainEventHub<SendQueueEvent> sendQueueEventHub)
            {
                _contexto = contexto;
                _usuarioService = usuarioService;
                _mapper = mapper;
                _email = email;
                SendQueueEventHub = sendQueueEventHub;
            }

            public async Task<CiudadanoInfoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var remote = _mapper.Map<UsuarioRemote>(request);
                remote = UsuarioRemotoConvert.Usuario(remote, request);
                //var remote = _mapper.Map<UsuarioRemote>(request);
                //remote.idAplicacion = "0ce1e976-d33a-4ee0-ab86-672539614136";
                //remote.nacionalidadId = "1";
                //remote.confirmPassword = request.Password;
                //remote.rol = "buscador";
                //remote.cuentaVerificada = true;
                //if(remote.direccion is not null)
                //{
                //    remote.direccion.paisId = request.PaisResidenciaId;
                //    remote.direccion.departamentoId = int.Parse(request.DepartamentoResidenciaId);
                //    remote.direccion.municipioId    = int.Parse(request.MunicipioResidenciaId);
                //    remote.direccion.localidadComunaId = request.LocalidadComunaId.Value;
                //    remote.direccion.estado = request.Estado;
                //    remote.direccion.ciudad = request.Ciudad;
                //    remote.direccion.codigoPostal = request.CodigoPostal;
                //    remote.direccion.perteneceARural = request.PerteneceARural.ToString();
                //    remote.direccion.barrio = request.barrioResidencia;
                //}

                var usuario = await _usuarioService.CrearUsuario(remote);

                //validar si id existe
                var ciudadanoinfo = await _contexto.Ciudadano.Where(x => x.Id == Guid.Parse(usuario.usuario.id)).FirstOrDefaultAsync();
                if (ciudadanoinfo != null)
                {
                    return _mapper.Map<CiudadanoModel, CiudadanoInfoDTO>(ciudadanoinfo);
                }
                else if (usuario.resultado)
                {
                    try
                    {
                        ICollection<CiudadanoTipoNotificacionModel> tipoNotificaicon = new List<CiudadanoTipoNotificacionModel>();
                        foreach (var id in request.TipoNotificacion)
                        {
                            tipoNotificaicon.Add(new CiudadanoTipoNotificacionModel { tipoNotificacionId = id });
                        }
                        var ciudadano = _mapper.Map<Ejecuta, CiudadanoModel>(request);
                        ciudadano.UsuarioId = Guid.Parse(usuario.usuario.id);
                        ciudadano.TipoNotificacion = tipoNotificaicon;
                        ciudadano.Id = Guid.Parse(usuario.usuario.id);

                        var avance = await CalculoAvanceHojaVida.procesarAsync(_contexto, ciudadano, "Registro buscadores");
                        ciudadano.PorcentajeRegistro = avance.Avance;
                        ciudadano.PorcentajeHv = avance.AvanceTotal;
                        ciudadano.PorcentajeInfoPersonal = 0;
                        ciudadano.PorcentajeEduFormal = 0;
                        ciudadano.PorcentajeInfoLaboral = 0;
                        ciudadano.PorcentajeEduNoFormal = 0;
                        //ciudadano.Autorregistro = true;
                        ciudadano.FechaTerminosCondiciones = DateTime.Now;
                        ciudadano.FechaTratamientoDatos = DateTime.Now;

                        if (request.Direcciones is not null)
                        {
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

                                    //CiudadanoId = (Guid)dir.CiudadanoId,
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
                            }
                        }


                        _contexto.Ciudadano.Add(ciudadano);
                        var respuesta = await _contexto.SaveChangesAsync();

                        if (respuesta > 0)
                        {
                            var mensaje = htmlEmail().Replace("@nombreCompleto", $"{ciudadano.PrimerNombre} {ciudadano.PrimerApellido}");
                            _email.Send(ciudadano.CorreoElectronico, "Registro de cuenta", mensaje);

                            RaiseEventItIsSuccess(ciudadano);

                            return _mapper.Map<CiudadanoModel, CiudadanoInfoDTO>(ciudadano);
                        }

                        throw new Exception("Error al gurdar el Ciudadano");
                    }
                    catch (Exception e)
                    {

                        throw new Exception(e.Message);
                    }

                }

                throw new Exception(usuario.errorMesaje);

            }
            private string htmlEmail()
            {
                return @"Hola @nombreCompleto, <br>
               ¡bienvenido! Has completado exitosamente el registro en el Servicio Público de Empleo.";
            }

            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.Id.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "Ciudadano",
                            Registro = new RegistroDto
                            {
                                Id = ciudadano.Id.ToString(),
                                Proceso = "Creacion"
                            }
                        }
                    }
                };

                SendQueueEventHub.Raise(message);
            }
        }
    }
}

