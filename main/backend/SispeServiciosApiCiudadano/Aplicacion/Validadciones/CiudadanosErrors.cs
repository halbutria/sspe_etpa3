namespace SispeServicios.Api.Ciudadano.Aplicacion
{
    public class CiudadanosErrors
    {
        public static string cedeulaNumeroError { get; set; } = "El tipo de documento es cedula solo se permiten numeros.";
        public static string TipoDocuementoNoValidoError { get; set; } = "El numero de documento es invalido.";
        public static string DepartamentoNoValidoError { get; set; } = "El departamento es invalido.";
        public static string MunicipioNoValidoError { get; set; } = "El departamento es invalido.";
    }
}
