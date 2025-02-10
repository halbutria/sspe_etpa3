using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServiciosApiCiudadano.Modelo
{
    [Table("Cliente", Schema = "People")]
    public class PersonaModel
    {
        public string Id { get; set; } = null!;
        public int TipoPersona { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? RazonSocial { get; set; }
        public  bool Activo { get; set; }
        public int? TipoDocumentoId { get; set; }
    }
}
