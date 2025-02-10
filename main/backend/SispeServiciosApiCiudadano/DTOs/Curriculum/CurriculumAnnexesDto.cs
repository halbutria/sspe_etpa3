using System.Diagnostics.CodeAnalysis;

namespace SispeServiciosApiCiudadano.DTOs.Curriculum
{
    /// <summary>
    ///   <see cref="CurriculumAnnexesDto" />
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class CurriculumAnnexesDto
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; } = default!;
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; } = default!;
        /// <summary>
        /// Gets or sets the file description.
        /// </summary>
        /// <value>
        /// The file description.
        /// </value>
        public string FileDescription { get; set; } = default!;
        /// <summary>
        /// Gets or sets the file code.
        /// </summary>
        /// <value>
        /// The file code.
        /// </value>
        public int FileCode { get; set; } = default!;
        /// <summary>
        /// Gets or sets the type of the search engine.
        /// </summary>
        /// <value>
        /// The type of the search engine.
        /// </value>
        public int SearchEngineType { get; set; } = default!;
        /// <summary>
        /// Gets or sets the search engine number.
        /// </summary>
        /// <value>
        /// The search engine number.
        /// </value>
        public string SearchEngineNumber { get; set; } = default!;
        /// <summary>
        /// Gets or sets the upload date.
        /// </summary>
        /// <value>
        /// The upload date.
        /// </value>
        public DateTime UploadDate { get; set; }
        /// <summary>
        /// Gets or sets the file concatenation.
        /// </summary>
        /// <value>
        /// The file concatenation.
        /// </value>
        public int FileConcatenation { get; set; } = default!;
        /// <summary>
        /// Gets or sets the name of the internal.
        /// </summary>
        /// <value>
        /// The name of the internal.
        /// </value>
        public string InternalName { get; set; } = default!;
        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        /// <value>
        /// The file.
        /// </value>
        public string File { get; set; } = default!;
        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public string FileExtension { get; set; } = default!;
    }
}
