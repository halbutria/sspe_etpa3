using System.Net;
using System.Reflection;
using System.Text.Json;
using log4net.Config;
using log4net;
using Microsoft.AspNetCore.Http;
using SispeServicios.Control.Exepcion.Exceptions;
using KeyNotFoundException = SispeServicios.Control.Exepcion.Exceptions.KeyNotFoundException;
using NotImplementedException = SispeServicios.Control.Exepcion.Exceptions.NotImplementedException;
using UnauthorizedAccessException = SispeServicios.Control.Exepcion.Exceptions.UnauthorizedAccessException;


namespace SispeServicios.Control.Exepcion.Configurations
{
    public class GlobalErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {

            


            HttpStatusCode status;
            string stackTrace = string.Empty;
            string[] message;

            var exceptionType = exception.GetType();

            if (exceptionType == typeof(BadRequestException))
            {
                message = new string[] { exception.Message };
                status = HttpStatusCode.BadRequest;
                stackTrace = exception?.StackTrace;
            }
            else if (exceptionType == typeof(NotFoundException))
            {
                message = new string[] { exception.Message };
                status = HttpStatusCode.NotFound;
                stackTrace = exception.StackTrace;
            }
            else if (exceptionType == typeof(NotImplementedException))
            {
                status = HttpStatusCode.NotImplemented;
                message = new string[] { exception.Message };
                stackTrace = exception.StackTrace;
            }
            else if (exceptionType == typeof(UnauthorizedAccessException))
            {
                status = HttpStatusCode.Unauthorized;
                message = new string[] { exception.Message };
                stackTrace = exception.StackTrace;
            }
            else if (exceptionType == typeof(KeyNotFoundException))
            {
                status = HttpStatusCode.Unauthorized;
                message = new string[] { exception.Message };
                stackTrace = exception.StackTrace;

            }
            else
            {
                status = HttpStatusCode.InternalServerError;
                message = new string[] { exception.Message };
                stackTrace = exception.StackTrace;                              

            }


            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            string path = Path.GetFullPath("..\\SispeServicios.Control.Exepcion\\log4net.config");
            XmlConfigurator.Configure(logRepository, new FileInfo(path));
            var demo = new Logger();

            demo.Error(stackTrace);


            var exceptionResult = JsonSerializer.Serialize(new { status, errors = new {error = message } });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;

            return context.Response.WriteAsync(exceptionResult);
        }

    }
}