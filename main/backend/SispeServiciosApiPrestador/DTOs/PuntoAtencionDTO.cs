namespace SispeServicios.Api.Prestador.DTOs
{
    public class PuntoAtencionDTO
    {
        public Guid Id { get; set; }
        public Guid PrestadorId { get; set; }
        public string Nombre { get; set; }

    }
}
