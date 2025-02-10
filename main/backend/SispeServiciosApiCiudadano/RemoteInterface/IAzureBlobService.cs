namespace SispeServiciosApiCiudadano.RemoteInterface
{
    /// <summary>
    /// <see cref="IAzureBlobService"/>
    /// </summary>
    public interface IAzureBlobService
    {
        /// <summary>
        /// Uploads the file asynchronous.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="containerAndPath">Name of the container.</param>
        /// <returns></returns>
        Task<string?> UploadFileAsync(Stream fileStream, string fileName, string containerAndPath);
    }
}