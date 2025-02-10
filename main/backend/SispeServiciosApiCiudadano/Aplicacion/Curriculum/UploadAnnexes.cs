using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.DTOs.Curriculum;
using SispeServiciosApiCiudadano.Modelo.CurriculumAnnexes;
using SispeServiciosApiCiudadano.RemoteInterface;

namespace SispeServiciosApiCiudadano.Aplicacion.Curriculum
{
    /// <summary>
    /// <see cref="UploadAnnexes"/>
    /// </summary>
    public class UploadAnnexes
    {
        /// <summary>
        ///   <see cref="Ejecuta" />
        /// </summary>
        /// <seealso cref="MediatR.IRequest&lt;System.Boolean&gt;" />
        /// <seealso cref="IRequest&lt;string&gt;" />
        public class Ejecuta : IRequest<CurriculumAnnexesResponseDto>
        {
            /// <summary>
            /// Gets or sets the anexo.
            /// </summary>
            /// <value>
            /// The anexo.
            /// </value>
            public CurriculumAnnexesDto Annexes { get; set; } = default!;
        }

        /// <summary>
        /// <see cref="Manejador"/>
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler&lt;SispeServiciosApiCiudadano.Aplicacion.Curriculum.UploadAnnexes.Ejecuta, System.Boolean&gt;" />
        public class Manejador : IRequestHandler<Ejecuta, CurriculumAnnexesResponseDto>
        {
            /// <summary>
            /// The BLOB service
            /// </summary>
            private readonly IAzureBlobService BlobService;
            /// <summary>
            /// The contexto
            /// </summary>
            private readonly Contexto Contexto;
            /// <summary>
            /// The mapper
            /// </summary>
            private readonly IMapper Mapper;
            /// <summary>
            /// Initializes a new instance of the <see cref="Manejador"/> class.
            /// </summary>
            /// <param name="blobService">The BLOB service.</param>
            /// <param name="contexto">The contexto.</param>
            public Manejador(IAzureBlobService blobService,
                             Contexto contexto,
                             IMapper mapper)
            {
                BlobService = blobService;
                Contexto = contexto;
                Mapper = mapper;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>
            /// Response from the request
            /// </returns>
            public async Task<CurriculumAnnexesResponseDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CurriculumAnnexesResponseDto CurriculumAnnexesResponse = new();
                byte[] fileBytes = Convert.FromBase64String(request.Annexes.File);
                using var stream = new MemoryStream(fileBytes);
                string ContainerName = $"{request.Annexes.SearchEngineNumber}/{request.Annexes.FileCode}";
                var urlFile = await BlobService.UploadFileAsync(stream, request.Annexes.FileName, ContainerName);

                CurriculumAnnexesResponse.IsUpload = urlFile is not null && !urlFile.StartsWith("Error");

                CurriculumAnnexesResponse.Message = urlFile!;

                if (CurriculumAnnexesResponse.IsUpload)
                {
                    CurriculumAnnexesModel CurriculumAnnexesModel = Mapper.Map<CurriculumAnnexesModel>(request.Annexes);
                    CurriculumAnnexesModel.BlodPath = CurriculumAnnexesResponse.Message.Split("?")[0];
                    await Contexto.AnexosHojaDeVida.AddAsync(CurriculumAnnexesModel, cancellationToken);
                    await Contexto.SaveChangesAsync(cancellationToken);
                }

                return CurriculumAnnexesResponse;
            }
        }

    }
}