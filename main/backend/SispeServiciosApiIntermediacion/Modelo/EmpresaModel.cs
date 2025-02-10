using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class EmpresaModel : EntidadBase
    {
        public int Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? RazonSocial { get; set; }
        public int? IdCarga { get; set; }
        public List<EmpresaSedeModel>? Sedes { get; set; }
    }
}
