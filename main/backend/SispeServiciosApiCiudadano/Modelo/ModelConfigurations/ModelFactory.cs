using Microsoft.EntityFrameworkCore;
using SispeServiciosApiCiudadano.Modelo.CurriculumAnnexes;

namespace SispeServiciosApiCiudadano.Modelo.ModelConfigurations
{
    /// <summary>
    /// <see cref="ModelFactory"/>
    /// </summary>
    public static class ModelFactory
    {
        /// <summary>
        /// Gets the curriculum annexes configuration.
        /// </summary>
        /// <value>
        /// The curriculum annexes configuration.
        /// </value>
        public static IEntityTypeConfiguration<CurriculumAnnexesModel> CurriculumAnnexesConfiguration => new CurriculumAnnexesConfiguration();
    }
}
