using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Validadciones
{
    public static class ParametricoValidator
    {
        public static async Task<bool> ValidAsync(string valor, string tipo , IParametricoService parametrcico, string? departamentoId = null)//
        {

            var respuesta = await  parametrcico.ConsultaParametrico(new ParametricoRemoteInput { tipo = tipo, id = valor,departamentoId= departamentoId });

            return respuesta.resultado;
        }
    }

}
