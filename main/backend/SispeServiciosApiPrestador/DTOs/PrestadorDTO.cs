namespace SispeServicios.Api.Prestador.DTOs
{
    public class PrestadorDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string DepartamentoId { get; set; }
        public bool CoberturaNacional { get; set; }
    }
}
