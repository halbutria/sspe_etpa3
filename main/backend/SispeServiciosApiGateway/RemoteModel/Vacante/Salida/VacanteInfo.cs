using SispeServicios.Api.Gateway.RemoteModel.Empresa;
using SispeServicios.Api.Gateway.RemoteModel.Vacante;
using SispeServicios.Api.Gateway.RemoteModel.Vacante.Entrada;
using SispeServicios.Api.Gateway.RemoteModel.Vacante.Salida;

namespace SispeServicios.Api.Gateway.RemoteModel.Salida
{
    public class VacanteInfo
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaVencimientoVacante { get; set; }
        public DateTime? FechaLimiteEnvioHv { get; set; }
        public List<VacanteUbicacion>? Ubicaciones { get; set; }
        public int? PuestosRequeridos { get; set; }
        public VacanteEstadoRemote? Estado { get; set; }
        public VacanteEmpresa? Empresa { get; set; }
        public bool? EsHidrocarburos { get; set; }
        //public string? Empresa { get; set; }
        //public string? ResponsableCorreo { get; set; }
        //public string? Responsable{ get; set; }
    }
}
