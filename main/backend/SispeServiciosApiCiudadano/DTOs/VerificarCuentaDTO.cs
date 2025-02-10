namespace SispeServiciosApiCiudadano.DTOs
{
    public class VerificarCuentaDTO
    {
        public bool existe { get; set; }
        public bool? activo { get; set; }
        public long key { get; set; }
    }
}
