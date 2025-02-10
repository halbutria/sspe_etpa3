namespace SispeServicios.Api.Ciudadano.Aplicacion.Validadciones
{

    public static class NumeroDocumentoValidator
    {
        public static bool Valid(int tipo, string numero)
        {
            int i = 0;
            if (tipo == 1 && int.TryParse(numero, out i)) return true;
            return false;
        }
    }
}