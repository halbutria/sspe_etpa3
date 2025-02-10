namespace SispeServicios.Api.Ciudadano.RemoteModel
{
    public class UsuarioRemoteOutput
    {
        public string id { get; set; }
        public bool active { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int sexoId { get; set; }
        public DateTime fechaExpedicionDocumento { get; set; }
        public string codigoCompaniaPrincipal { get; set; }
        public string cargo { get; set; }
        public string rol { get; set; }
        public string password { get; set; }
        public string idAplicacion { get; set; }
        public string nacionalidadId { get; set; }
        public int tipoDocumentoId { get; set; }
        public string numeroDocumento { get; set; }
        public string telefono { get; set; }
        public string otroTelefono { get; set; }
        public string correoElectronico { get; set; }
        public string prestadorPreferenciaId { get; set; }
        public string puntoAtencionId { get; set; }
        public int preguntaSeguridadId { get; set; }
        public string preguntaSeguridadRespuesta { get; set; }
        public string preguntaLibre { get; set; }
        public bool terminosCondiciones { get; set; }
        public bool tratamientoDatosPersonales { get; set; }
        public List<TipoNotificacionRemote> tipoNotificacion { get; set; }
        public DireccionRemote direccion { get; set; }
        public bool cuentaVerificada { get; set; }
    }



}
