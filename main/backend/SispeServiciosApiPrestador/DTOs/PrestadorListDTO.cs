namespace SispeServicios.Api.Prestador.DTOs
{
    public class PrestadorListDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string DepartamentoId { get; set; }
        public string MunicipioId { get; set; }
        public string ClasePrestador { get; set; }
        public string Direccion { get; set; }
        public string Vigencia { get; set; }
        public string Estado { get; set; }
    }
}
