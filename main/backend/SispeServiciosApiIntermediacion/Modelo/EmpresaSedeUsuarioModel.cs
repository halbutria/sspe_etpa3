using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class EmpresaSedeUsuarioModel : EntidadBase
    {
        public int EmpresaSedeId { get; set; }
        public Guid EmpresaUsuarioId { get; set; }
        public bool EsPrincipal { get; set; }
        public int? IdCarga { get; set; }
        public EmpresaSedeModel? EmpresaSede { get; set; }
        public EmpresaUsuarioModel? EmpresaUsuario { get; set; }

        //public List<EmpresaSedeModel>? Sedes { get; set; }
        //public List<EmpresaUsuarioModel>? Usuarios { get; set; }
    }
}
