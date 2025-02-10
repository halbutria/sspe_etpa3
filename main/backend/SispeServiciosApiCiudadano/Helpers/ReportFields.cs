namespace SispeServicios.Api.Ciudadano.Helpers
{
    public class ReportFields
    {
        public static readonly Dictionary<string, string> ParentFields = new Dictionary<string, string>
        {
            { "DepartamentoResidenciaId", "Ciudadano" },
            { "MunicipioResidenciaId", "Ciudadano" },
            { "FechaNacimiento", "Ciudadano" },
            { "SexoId", "Ciudadano" },
            { "PosibilidadViajar", "Ciudadano" },
            { "PosibilidadTrasladarse", "Ciudadano" },
            { "CategoriaLicenciaCarroId", "Ciudadano" },
            { "CategoriaLicenciaMotoId", "Ciudadano" },
            { "PerteneceARural", "Ciudadano" },
            { "CertificadoResidencia", "Ciudadano" },
            { "PerfilLaboral", "Ciudadano" },
            { "EstadoCiudadanoId", "Ciudadano" }
        };


        public static readonly Dictionary<string, string> FieldsCiudadanoUpdate = new Dictionary<string, string>
        {
            { "CargoIneteres", "Ciudadano" },
            { "CondicionDiscapacidad", "Ciudadano" },
            { "CondicionSaludMental", "Ciudadano" },
            { "TipoPoblacion", "Ciudadano" },
            { "GrupoEtnico", "Ciudadano" }
        };
    }
}