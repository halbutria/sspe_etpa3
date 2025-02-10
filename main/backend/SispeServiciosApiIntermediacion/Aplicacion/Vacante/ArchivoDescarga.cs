using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Archivo.S3;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Vacante
{
    public class ArchivoDescarga
    {
        public class Ejecuta : IRequest<FileStreamResult>
        {
            public Guid ArchivoId { get; set; }
            public Guid VacanteId { get; set; }
            public string Tipo { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, FileStreamResult>
        {
            private Contexto _contexto;
            private IMapper _mapper;
            private readonly IStorageService _storageService;
            private readonly IConfiguration _config;

            public Manejador(Contexto contexto, IMapper mapper, IStorageService storageService, IConfiguration config)
            {
                _contexto = contexto;
                _mapper = mapper;
                _storageService = storageService;
                _config = config;
            }

            public async Task<FileStreamResult> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.VacanteArchivo.FirstOrDefaultAsync(x => x.Id == request.ArchivoId && x.TipoArchivo == request.Tipo);
                if (info is not null)
                {
                    try
                    {
                        var config = new ConfigStorage()
                        {
                            Repository = _config["ConfigStorage:Repository"],
                            SecretKey = _config["ConfigStorage:SecretKey"],
                            AccessKey = _config["ConfigStorage:AccessKey"],
                            FileName = info.NombreArchivoRepositorio
                        };
                        var archivo = await _storageService.GetDocument(config);
                        return new FileStreamResult(archivo.FileStream, archivo.ContentType)
                        {
                            FileDownloadName = info.NombreArchivo
                        };
                    }
                    catch (Exception e)
                    {

                        throw new Exception(e.Message);
                    }

                    
                }
                throw new Exception("No existe Informacion.");
            }
        }
    }
}
