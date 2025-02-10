using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class EmpresaSedeModel : EntidadBase
    {
        public int Id { get; set; }
        public Guid PuntoAtencionId { get; set; }
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int? IdCarga { get; set; }
        public EmpresaModel? Empresa { get; set; }
        public List<EmpresaSedeUsuarioModel>? Usuarios { get; set; }

    }
}
