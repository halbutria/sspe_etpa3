using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3Control.Model;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace SispeServicios.Archivo.S3
{
    public class S3StorageService : IStorageService
    {
        //private readonly IConfigurationManager _config;

        //public StorageService(IStorageService config)
        //{
        //    //_config = config;
        //}

        public async Task<ResponseDto> DeleteDocument(ConfigStorage config)
        {
            var response = new ResponseDto();

            try
            {

                var awsCredentialsValues = new AwsCredentials()
                {
                    AccessKey = config.AccessKey,// "AKIAR2KS3LNIAGVUHPEU",//_config["AwsConfiguration:AWSAccessKey"],
                    SecretKey = config.SecretKey// "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" //_config["AwsConfiguration:AWSSecretKey"]
                };


                Console.WriteLine($"Key: {awsCredentialsValues.AccessKey}, Secret: {awsCredentialsValues.SecretKey}");

                var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

                var configS3 = new AmazonS3Config()
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1
                };

                using var client = new AmazonS3Client(credentials, configS3);
                var fileTransferUtility = new TransferUtility(client);


                DeleteObjectRequest request = new DeleteObjectRequest
                {
                    BucketName = config.Repository,
                    Key = config.FileName
                };


                var objectResponse = await client.DeleteObjectAsync(request);

                response.StatusCode = (int)objectResponse.HttpStatusCode;
                response.Message = $"{config.FileName} has been deleted sucessfully";

            }
            catch (AmazonS3Exception s3Ex)
            {
                response.StatusCode = (int)s3Ex.StatusCode;
                response.Message = s3Ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<ResponseDto> GetDocument(ConfigStorage config)
        {
            var response = new ResponseDto();

            try
            {

                var awsCredentialsValues = new AwsCredentials()
                {
                    AccessKey = config.AccessKey,// "AKIAR2KS3LNIAGVUHPEU",//_config["AwsConfiguration:AWSAccessKey"],
                    SecretKey = config.SecretKey// "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" //_config["AwsConfiguration:AWSSecretKey"]
                };


                Console.WriteLine($"Key: {awsCredentialsValues.AccessKey}, Secret: {awsCredentialsValues.SecretKey}");

                var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

                var configS3 = new AmazonS3Config()
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1
                };

                using var client = new AmazonS3Client(credentials, configS3);
                var fileTransferUtility = new TransferUtility(client);

                var objectResponse = await fileTransferUtility.S3Client.GetObjectAsync(new GetObjectRequest()
                {
                    BucketName = config.Repository,
                    Key = config.FileName
                });
                response.FileStream = objectResponse.ResponseStream;
                response.ContentType = objectResponse.Headers.ContentType;
                response.StatusCode = (int)objectResponse.HttpStatusCode;
                response.Message = $"{config.FileName} has been get sucessfully";
            }
            catch (AmazonS3Exception s3Ex)
            {
                response.StatusCode = (int)s3Ex.StatusCode;
                response.Message = s3Ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<ResponseDto> UploadFileAsync(ConfigStorage config)
        {


            // Process file
            await using var memoryStream = new MemoryStream();
            await config.File.CopyToAsync(memoryStream);

            var fileExt = Path.GetExtension(config.File.FileName);
            var docName = $"{config.FileName}{fileExt}";

            var awsCredentialsValues = new AwsCredentials()
            {
                AccessKey = config.AccessKey, //"AKIAR2KS3LNIAGVUHPEU",//_config["AwsConfiguration:AWSAccessKey"],
                SecretKey = config.SecretKey//"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" //_config["AwsConfiguration:AWSSecretKey"]
            };


            Console.WriteLine($"Key: {awsCredentialsValues.AccessKey}, Secret: {awsCredentialsValues.SecretKey}");

            var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

            var configS3 = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };

            var response = new ResponseDto();
            try
            {
                var uploadRequest = new TransferUtilityUploadRequest()
                {
                    InputStream = memoryStream,
                    Key = docName,
                    BucketName = config.Repository,
                    CannedACL = S3CannedACL.NoACL
                };

                // initialise client
                using var client = new AmazonS3Client(credentials, configS3);

                // initialise the transfer/upload tools
                var transferUtility = new TransferUtility(client);

                // initiate the file upload
                await transferUtility.UploadAsync(uploadRequest);
                
                response.FileNameRespository = docName;
                response.FileName = config.File.FileName;
                response.StatusCode = 201;
                response.Message = $"{response.FileName} has been uploaded sucessfully";
            }
            catch (AmazonS3Exception s3Ex)
            {
                response.StatusCode = (int)s3Ex.StatusCode;
                response.Message = s3Ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
