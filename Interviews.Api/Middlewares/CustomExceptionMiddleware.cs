using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Interviews.Common.Exceptions;
using System.Net;
using Newtonsoft.Json;

namespace Interviews.Api.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionMiddleware> _loggerFactory;

        public CustomExceptionMiddleware(RequestDelegate next, ILogger<CustomExceptionMiddleware> loggerFactory)
        {
            _next = next;
            _loggerFactory = loggerFactory;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {

                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {

            // Error unique code generator
            string errorUniqueCode = $"{DateTime.Now.ToString("yyyyMMddHmmss")}_{Guid.NewGuid().ToString("N")}";

            var response = context.Response;
            var customException = exception as BaseCustomException;
            var statusCode = (int)HttpStatusCode.InternalServerError;
            var message = "Unexpected Error";
            var description = "UnexpectedError";

            if (customException != null)
            {
                message = customException.Message;
                description = customException.Description;
                statusCode = customException.Code;
            }

            response.ContentType = "application/json";
            response.StatusCode = statusCode;

            // Log the error
            _loggerFactory.LogError(exception, $"##{errorUniqueCode}##-{exception.Message}");

            await response.WriteAsync(JsonConvert.SerializeObject(new
            {
                Message = message,
                Description = description,
                InternalErrorUniqueCode = errorUniqueCode
            }));
        }
    }
}
