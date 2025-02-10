using SispeServicios.Api.Gateway.RemoteModel.Empresa;

namespace SispeServicios.Api.Gateway.RemoteInterface
{
    public interface IEmpresaService
    {
        public Task<(bool resultado, SedeRemote? sede, string? errorMesaje)> ConsultarSede(int? sedeId);
    }
}
