using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Utils
{
    public static class CalculoAvanceHojaVida
    {
        public static async Task<(decimal? Avance, decimal? AvanceTotal, bool HojaVidaCompleta)> procesarAsync(Contexto _contexto, CiudadanoModel ciudadano, string Tipo)
        {
            decimal? Avance;
            decimal? AvanceTotal;
            bool HojaVidaCompleta;
            var consulta = await _contexto.ConfiguracionAvanceHojaVida.FirstOrDefaultAsync(x => x.Tipo == Tipo);
            Avance = consulta?.Avance;
            ciudadano.PorcentajeRegistro     = (Tipo == "Registro buscadores")             ? Avance : ciudadano.PorcentajeRegistro     ?? 0;
            ciudadano.PorcentajeInfoPersonal = (Tipo == "Información personal")  ? Avance : ciudadano.PorcentajeInfoPersonal ?? 0;
            ciudadano.PorcentajeEduFormal    = (Tipo == "Educación formal")      ? Avance : ciudadano.PorcentajeEduFormal    ?? 0;
            ciudadano.PorcentajeInfoLaboral  = (Tipo == "Experiencia laboral")   ? Avance : ciudadano.PorcentajeInfoLaboral  ?? 0;
            ciudadano.PorcentajeEduNoFormal  = (Tipo == "Educación no formal")    ? Avance : ciudadano.PorcentajeEduNoFormal  ?? 0;

            AvanceTotal =
                ciudadano.PorcentajeRegistro +
                ciudadano.PorcentajeInfoPersonal  +
                ciudadano.PorcentajeEduFormal  +
                ciudadano.PorcentajeInfoLaboral +
                ciudadano.PorcentajeEduNoFormal;

            AvanceTotal = (AvanceTotal >= 100) ? 100 : AvanceTotal;
            HojaVidaCompleta = (AvanceTotal >= 100)?true:false;
            return (Avance, AvanceTotal, HojaVidaCompleta);

        }
    }
}
