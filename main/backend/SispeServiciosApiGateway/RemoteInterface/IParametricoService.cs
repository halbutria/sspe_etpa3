using SispeServicios.Api.Gateway.RemoteModel;

namespace SispeServicios.Api.Gateway.RemoteInterface
{
    public interface IParametricoService
    {
        public Task<(bool resultado, ParametricoConsultaOutputRemote? parametrico, string? errorMesaje)> ConsultarParametrico(ParametricoConsultaInputRemote parametrico);
    }
}
