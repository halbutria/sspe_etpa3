using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.Persistencia;

namespace SispeServiciosApiIntermediacion.Aplicacion.Validadciones
{
    public static class HidrocarburosValidator
    {
        public static async Task<bool> CodigoInternoVacanteUnicoAsync(string? codigo, Contexto _contexto, Guid? id = null)
        {
            if (codigo == null)
            {
                return true;
            }
            var existe = await _contexto.Vacantes.Where(x=>x.CodigoInternoVacante == codigo).FirstOrDefaultAsync();
            if (existe != null && id == null)
            {
                return false;
            }
            else if(existe?.Id != id)
            {
                return false;
            }
            return true;
        }
    }
}
