using System.Diagnostics.CodeAnalysis;

namespace SispeServiciosApiCiudadano.DTOs.Curriculum
{
    /// <summary>
    /// <see cref="CurriculumAnnexesResponseDto"/>
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class CurriculumAnnexesResponseDto
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is upload.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is upload; otherwise, <c>false</c>.
        /// </value>
        public bool IsUpload { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; } = default!;
    }
}
