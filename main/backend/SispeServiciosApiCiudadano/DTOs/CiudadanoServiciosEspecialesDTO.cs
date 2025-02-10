namespace SispeServiciosApiCiudadano.DTOs
{
    public class CiudadanoServiciosEspecialesDTO
    {
        public Guid? Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int CodigoServicioEspecial { get; set; }
        public string TipoServicio { get; set; } = string.Empty;
        public int CodigoTipoServicio { get; set; }
    }
}
