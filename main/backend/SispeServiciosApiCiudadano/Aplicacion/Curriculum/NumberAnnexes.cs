using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServiciosApiCiudadano.Aplicacion.Curriculum
{
    /// <summary>
    /// <see cref="NumberAnnexes"/>
    /// </summary>
    public class NumberAnnexes
    {
        /// <summary>
        ///   <see cref="Ejecuta" />
        /// </summary>
        /// <seealso cref="MediatR.IRequest&lt;System.Boolean&gt;" />
        /// <seealso cref="IRequest&lt;string&gt;" />
        public class Ejecuta : IRequest<int>
        {
            /// <summary>
            /// Gets or sets the file code.
            /// </summary>
            /// <value>
            /// The file code.
            /// </value>
            public int FileCode { get; set; }
            /// <summary>
            /// Gets or sets the search engine number.
            /// </summary>
            /// <value>
            /// The search engine number.
            /// </value>
            public string SearchEngineNumber { get; set; } = default!;
        }

        /// <summary>
        /// <see cref="Manejador"/>
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler&lt;SispeServiciosApiCiudadano.Aplicacion.Curriculum.UploadAnnexes.Ejecuta, System.Boolean&gt;" />
        public class Manejador : IRequestHandler<Ejecuta, int>
        {
            /// <summary>
            /// The contexto
            /// </summary>
            private readonly Contexto Contexto;
            /// <summary>
            /// Initializes a new instance of the <see cref="Manejador"/> class.
            /// </summary>
            /// <param name="contexto">The contexto.</param>
            public Manejador(Contexto contexto) => Contexto = contexto;

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>
            /// Response from the request
            /// </returns>
            public async Task<int> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                int CantFiles = await Contexto.AnexosHojaDeVida.CountAsync(c => c.FileCode == request.FileCode &&
                                                                                c.SearchEngineNumber == request.SearchEngineNumber, cancellationToken);
                return CantFiles;
            }
        }
    }
}