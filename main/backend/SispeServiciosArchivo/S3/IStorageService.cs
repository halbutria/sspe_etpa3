using Microsoft.AspNetCore.Http;

namespace SispeServicios.Archivo.S3
{
    public interface IStorageService
    {
        public Task<ResponseDto> UploadFileAsync(ConfigStorage config);
        public Task<ResponseDto> GetDocument(ConfigStorage config);
        public Task<ResponseDto> DeleteDocument(ConfigStorage config);
    }
}
