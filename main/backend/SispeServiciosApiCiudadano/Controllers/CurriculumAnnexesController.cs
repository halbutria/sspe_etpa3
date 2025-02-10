using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiCiudadano.Aplicacion.Curriculum;
using SispeServiciosApiCiudadano.DTOs.Curriculum;
using System.ComponentModel.DataAnnotations;


namespace SispeServiciosApiCiudadano.Controllers
{
    /// <summary>
    /// <see cref="CurriculumAnnexesController"/>
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumAnnexesController : ControllerBase
    {
        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator _mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurriculumAnnexesController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public CurriculumAnnexesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Cargars the adjunto.
        /// </summary>
        /// <param name="archivo">The archivo.</param>
        /// <param name="tipoArchivo">The tipo archivo.</param>
        /// <param name="annexes">The annexes.</param>
        /// <returns></returns>
        [HttpPost("upload")]
        public async Task<IActionResult> CargarAdjunto([FromForm] CurriculumAnnexesDto annexes)
        {
            try
            {
                var command = new UploadAnnexes.Ejecuta { Annexes = annexes };
                var file = await _mediator.Send(command);
                if (file.IsUpload)
                    return Ok(new { message = "Archivo cargado exitosamente.", file });
                else
                    return BadRequest(new { error = $"Error al cargar el archivo, {file.Message}" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        /// <summary>
        /// Cantidads the adjuntos.
        /// </summary>
        /// <param name="FileCode">The file code.</param>
        /// <param name="SearchEngineNumber">The search engine number.</param>
        /// <returns></returns>
        [HttpGet("count/{FileCode}/{SearchEngineNumber}")]
        public async Task<IActionResult> CantidadAdjuntos([FromRoute, Required] int FileCode,
                                                          [FromRoute, Required] string SearchEngineNumber)
        {
            var Query = new NumberAnnexes.Ejecuta { FileCode = FileCode, SearchEngineNumber = SearchEngineNumber };
            var CantFiles = await _mediator.Send(Query);
            return Ok(CantFiles);
        }

    }
}
