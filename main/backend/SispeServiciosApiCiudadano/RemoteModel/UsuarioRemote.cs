namespace SispeServicios.Api.Ciudadano.RemoteModel
{
    public class UsuarioRemote
    {
        public string Id { get; set; }
        public int tipoDocumentoId { get; set; }
        public string numeroDocumento { get; set; }
        public string primerApellido { get; set; }
        public string? segundoApellido { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string correoElectronico { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string rol { get; set; }
        public string telefono { get; set; }
        public string otroTelefono { get; set; }
        public int preguntaSeguridadId { get; set; }
        public string preguntaSeguridadRespuesta { get; set; }
        public string preguntaLibre { get; set; }
        public string nacionalidadId { get; set; }
        public string prestadorPreferenciaId { get; set; }
        public string puntoAtencionId { get; set; }
        public bool terminosCondiciones { get; set; }
        public bool tratamientoDatosPersonales { get; set; }
        public List<TipoNotificacionRemote> tipoNotificacion { get; set; }
        public DireccionRemote direccion { get; set; }
        public bool cuentaVerificada { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int sexoId { get; set; }
        public DateTime fechaExpedicionDocumento { get; set; }
        public string idAplicacion { get; set; }
        public bool activo { get; set; } = true;
    }

    public class DireccionRemote
    {
        public int paisId { get; set; }
        public string departamentoId { get; set; }
        public string estado { get; set; }
        public string municipioId { get; set; }
        public string ciudad { get; set; }
        public string barrio { get; set; }
        public string perteneceARural { get; set; }
        public int? localidadComunaId { get; set; }
        public string direccion { get; set; }
        public string viaPrincipalId { get; set; }
        public string viaPrincipalNombre { get; set; }
        public string viaPrincipal { get; set; }
        public string viaPrincipalLetraId { get; set; }
        public string viaPrincipalLetraNombre { get; set; }
        public string viaPrincipalBisId { get; set; }
        public string viaPrincipalBisNombre { get; set; }
        public string viaPrincipalSegundaLetraId { get; set; }
        public string viaPrincipalSegundaLetraNombre { get; set; }
        public string viaPrincipalCuadranteId { get; set; }
        public string viaPrincipalCuadranteNombre { get; set; }
        public string signoNumero { get; set; }
        public string viaGeneradora { get; set; }
        public string viaGeneradoraLetraId { get; set; }
        public string viaGeneralLetraNombre { get; set; }
        public string viaGeneradoraPlaca { get; set; }
        public string viaGeneradoraCuadranteId { get; set; }
        public string viaGeneradoraCuadranteNombre { get; set; }
        public string codigoPostal { get; set; }
        public List<DireccionComplementoRemote> direccionComplemento { get; set; }
        public string id { get; set; }
    }

    public class DireccionComplementoRemote
    {
        public string direccionId { get; set; }
        public string complementoId { get; set; }
        public string complementoNombre { get; set; }
        public string complemento { get; set; }
    }

    public class TipoNotificacionRemote
    {
        public int notificationId { get; set; }
    }
}
