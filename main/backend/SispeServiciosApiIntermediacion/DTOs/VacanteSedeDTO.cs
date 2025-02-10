namespace SispeServicios.Api.Intermediacion.DTOs
{
    public class VacanteSedeDTO
    {
        public Guid Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? CorreoElectronico { get; set; }
    }
}
