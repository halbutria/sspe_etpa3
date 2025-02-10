using SispeServicios.Api.Parametrico.Modelo;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServicios.Api.Parametrico.DTOs
{
    public class ParametricoDTO
    {
        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Sigla { get; set; }

        //
        public string? DepartamentoId { get; set; }
        public string? DepartamentoInternacionalId { get; set; }

        public int? valorInicial { get; set; }
        public int? valorFinal { get; set; }

        public bool? Principal { get; set; }

        public string? tipo { get; set; }
        public int? orden { get; set; }

        public int? equivalencias { get; set; }
        public string? Descripcion { get; set; }
        public string? Nacionalidad { get; set; }

        public string? GrupoPrimario { get; set; }
        public string? OcupacionNueva { get; set; }
        public string? CUOCOcupacionId { get; set; }
        public string? FuenteDenominacion { get; set; }
        public string? CodigoCNO { get; set; }
        public string? CodigoCIUO { get; set; }

        public bool? Rural { get; set; }
        public int? TipoZonaGeograficaId { get; set; }

        public string? Detalle { get; set; }
        public int paisInternacionalId { get; set; }
        public string? Codigo { get; set; }
        public string? DiviPolo { get; set; }
        public float? Latitud { get; set; }
        public float? Longitud { get; set; }

        public string? Contenido { get; set; }
        public string? Texto { get; set; }

        public int? NivelEducativoId { get; set; }
        public int? NucleoConocimientoId { get; set; }

        public bool? RegistraInstitucion { get; set; }
        public int? InstitucionId { get; set; }
        public string? CUOCConocimientoId { get; set; }
        public decimal? Avance { get; set; }
        public int? SectorEconomicoId { get; set; }
        public int? AreaConocimientoId { get; set; }
        public int? TipoVacanteId { get; set; }
        public int? Peso { get; set; }
        public bool? Estado { get; set; }
        public int? NumeroIntentosIngreso { get; set; }

        public string? TiempoInactividad { get; set; }
        public string? TiempoActividad { get; set; }

        public int? cantidadAdjuntosHv { get; set; }
        public int? pesoMaximoArchivoAdjuntoHv { get; set; }
        public int? cantidadAdjuntosInformacionAcademica { get; set; }
        public int? pesoMaximoArchivoAdjuntoInformacionAcademica { get; set; }
        public int? cantidadAdjuntosInformacionLaboral { get; set; }
        public int? pesoMaximoArchivoAdjuntoInformacionLaboral { get; set; }
        public int? cantidadAdjuntosEducacionInformal { get; set; }
        public int? pesoMaximoArchivoAdjuntoEducacionInformal { get; set; }
        public int? cantidadAdjuntosIdiomas { get; set; }
        public int? pesoMaximoArchivoAdjuntoIdiomas { get; set; }
        public int? pesoMaximoArchivoAdjuntoFoto { get; set; }
        public int? cantidadEnlacesPermitidos { get; set; }
        public string? Pregunta { get; set; }
        public string? TipoRespuesta { get; set; }
        public string? Respuesta { get; set; }
        public string? Tema { get; set; }
        public string? Notificacion { get; set; }
        public List<Preguntas>? Preguntas { get; set; }
        //public List<PreguntasViewDto>? Preguntas { get; set; }
        public List<string>? Direccionamientos { get; set; }
        public int? Meses { get; set; }
        public List<RolModel>? RolModels { get; set; }
        public ModuloModel Modulo { get; set; }

        public int Semana { get; set; }
        public int EdadHombre { get; set; }
        public int EdadMujer { get; set; }
        public int SemanaCotizarHombre { get; set; }
        public int SemanaCotizarMujer { get; set; }
        public List<Notificaciones> Notificaciones { get; set; }
        public Guid? ModuloId { get; set; }
        public string? TiempoMaximo { get; set; }
        public string? TipoFormato { get; set; }
        public DateTimeOffset? FechaCreacion { get; set; }
        public DateTimeOffset? FechaModificacion { get; set; }
        public List<string> Opciones { get; set; }
        public int TipoPreguntasId { get; set; }
        public List<RespuestasSatisfaccionDiligenciamiento>? RespuestasSatisfaccionDiligenciamientos { get; set; }
        //public List<Respuestas> Respuestas { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public List<RespuestasSatisfaccionHerramienta> RespuestasSatisfaccionHerramienta { get; set; }
        public string Plantilla { get; set; }
        public int Grupo { get; set; }
        public int Tamanio { get; set; }
        public int NombreCriterio { get; set; }
        public int RangoCriterio { get; set; }
        public int EstadoNotificacion { get; set; }
        public int TipoCurso { get; set; }
        public string Duracion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string DescripcionComplementaria { get; set; }

        public int? TipoPersona { get; set; }
        public int? TipoDocumento { get; set; }
        public int? Naturaleza { get; set; }
        public int? TipoEmpresa { get; set; }
        public int? TamanioPorNumeroEmpleados { get; set; }
        public string? Modulos { get; set; }

        public int? ServiciosAsociadosId { get; set; }
        public int? BrechaServiciosAsociadosId { get; set; }

        public int? ServiciosBasicosId { get; set; }
        public int? BrechaServiciosBasicosId { get; set; }

        public int? ServiciosOfertaId { get; set; }
        public int? BrechaServiciosOfertaId { get; set; }
    }
    public class NotificacionesDTO
    {
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
    public class NotificacionesUpdDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
    public class PreguntasUpdDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public List<string> Opciones { get; set; }
    }

    public class PreguntasNewDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public List<string> Opciones { get; set; }
    }

    public class InactivaCuentaNewDTO
    {
        public string Pregunta { get; set; }
        public string TipoRespuesta { get; set; }
        public List<string> Opciones { get; set; }
        public string? Descripcion { get; set; }
    }

    public class RecoleccionEncuestas
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public List<string> Respuesta { get; set; }
    }
}
