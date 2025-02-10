namespace SispeServicios.Api.Ciudadano.Helpers
{
    public class ReportTables
    {
        public static readonly Dictionary<string, string> Tables = new Dictionary<string, string>
        {
            { "CargoInteres", "CiudadanoCargoInteres" },
            { "CondicionMental", "CiudadanoCondicionMental" },
            { "Discapacidad", "CiudadanoDiscapacidad" },
            { "EducacionFormal", "CiudadanoEducacionFormal" },
            { "EducacionNoFormal", "CiudadanoEducacionNoFormal" },
            { "ExperienciaPrevia", "CiudadanoExperiencia" },
            { "GrupoEtnico", "CiudadanoGrupoEtnico" },
            { "Destrezas", "CiudadanoHabilidadDestreza" },
            { "Idiomas", "CiudadanoIdioma" },
            { "InformacionLaboral", "CiudadanoInformacionLaboral" },
            { "TipoPoblacion", "CiudadanoTipoPoblacion" }
        };
    }
}




//o CiudadanoConocimientoCompetencia
//o	CiudadanoConocimientoCompetenciaExperienciaPrevia
//o	CiudadanoConocimientoCompetenciaInformacionLaboral
//o	CiudadanoHabilidadDestrezaExperienciaPrevia
//o	CiudadanoHabilidadDestrezaInformacionLaboral
