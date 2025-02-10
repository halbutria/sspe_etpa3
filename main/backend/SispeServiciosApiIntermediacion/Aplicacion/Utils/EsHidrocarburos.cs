using FluentValidation.Results;
using SispeServicios.Api.Intermediacion.Modelo;

namespace SispeServiciosApiIntermediacion.Aplicacion.Utils
{
    public static class EsHidrocarburos
    {
        public static bool validar(VacanteModel vacante)
        {
            return (vacante.SectorEconomicoId == 1 && vacante.SubsectorEconomicoId == 1) ? true : false;
        }
    }
}
