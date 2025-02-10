using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class EmpresaUsuarioModel : EntidadBase
    {
        public int TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? CorreoElectronico { get; set; }
        public int? IdCarga { get; set; }
        public List<EmpresaSedeUsuarioModel>? Responsables { get; set; }
        //public EmpresaModel? Empresa { get; set; }
        //public EmpresaSedeResponsableModel? Responsable { get; set; }
    }
}
