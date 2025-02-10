using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SispeServiciosApiCiudadano.Modelo.CurriculumAnnexes;

namespace SispeServiciosApiCiudadano.Modelo.ModelConfigurations
{
    /// <summary>
    /// <see cref="CurriculumAnnexesConfiguration"/>
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.IEntityTypeConfiguration&lt;SispeServiciosApiCiudadano.Modelo.CurriculumAnnexes.CurriculumAnnexesModel&gt;" />
    public class CurriculumAnnexesConfiguration : IEntityTypeConfiguration<CurriculumAnnexesModel>
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<CurriculumAnnexesModel> builder)
        {
            // Nombre de la tabla
            builder.ToTable("AnexosHojaDeVida");

            // Configuración de cada campo
            builder.Property(e => e.FileName)
                .HasColumnName("NombreArchivo")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.FilePath)
                .HasColumnName("RutaArchivo")
                .IsRequired()
                .HasMaxLength(600);

            builder.Property(e => e.FileDescription)
                .HasColumnName("DescripcionArchivo")
                .IsRequired()
                .HasMaxLength(3000);

            builder.Property(e => e.FileCode)
                .HasColumnName("CodigoArchivo")
                .IsRequired();

            builder.Property(e => e.SearchEngineType)
                .HasColumnName("TipoBuscador")
                .IsRequired();

            builder.Property(e => e.SearchEngineNumber)
                .HasColumnName("NumeroBuscador")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.UploadDate)
                .HasColumnName("FechaCarga")
                .IsRequired();

            builder.Property(e => e.FileConcatenation)
                .HasColumnName("ConcatenacionArchivo")
                .IsRequired();

            builder.Property(e => e.InternalName)
                .HasColumnName("NombreInterno")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.FileExtension)
                .HasColumnName("ExtensionArchivo")
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}