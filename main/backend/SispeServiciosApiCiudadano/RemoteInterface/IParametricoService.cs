using SispeServicios.Api.Ciudadano.RemoteModel;

namespace SispeServicios.Api.Ciudadano.RemoteInterface
{
    public interface IParametricoService
    {
        Task<(bool resultado, ParametricoRemoteOutput? parametrico, string? errorMesaje)> ConsultaParametrico(ParametricoRemoteInput parametrico);
    }
}
