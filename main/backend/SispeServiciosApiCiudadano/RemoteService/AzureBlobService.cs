using Azure.Storage.Blobs;
using SispeServiciosApiCiudadano.RemoteInterface;

namespace SispeServiciosApiCiudadano.RemoteService
{
    /// <summary>
    /// <see cref="AzureBlobService"/>
    /// </summary>
    /// <seealso cref="SispeServiciosApiCiudadano.RemoteInterface.IAzureBlobService" />
    public class AzureBlobService : IAzureBlobService
    {
        /// <summary>
        /// The BLOB service client
        /// </summary>
        private readonly BlobServiceClient _blobServiceClient;
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<AzureBlobService> Logger;
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureBlobService"/> class.
        /// </summary>
        /// <param name="blobServiceClient">The BLOB service client.</param>
        public AzureBlobService(BlobServiceClient blobServiceClient, ILogger<AzureBlobService> logger)
        {
            _blobServiceClient = blobServiceClient;
            Logger = logger;
        }

        /// <summary>
        /// Uploads the file asynchronous.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="containerName">Name of the container.</param>
        /// <returns></returns>
        public async Task<string?> UploadFileAsync(Stream fileStream, string fileName, string containerAndPath)
        {
            try
            {
                var Parts = containerAndPath.Split('/');
                var ContainerName = Parts[0];
                var DirectoryPath = string.Join("/", Parts.Skip(1));
                var ContainerClient = _blobServiceClient.GetBlobContainerClient(ContainerName);
                await ContainerClient.CreateIfNotExistsAsync();
                var BlobName = string.IsNullOrEmpty(DirectoryPath) ? fileName : $"{DirectoryPath}/{fileName}";
                var BlobClient = ContainerClient.GetBlobClient(BlobName);
                await BlobClient.UploadAsync(fileStream, true);
                return BlobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.InnerException?.Message ?? ex.Message, ex);
                return $"Error: {ex.InnerException?.Message ?? ex.Message}";
            }
        }
    }
}
