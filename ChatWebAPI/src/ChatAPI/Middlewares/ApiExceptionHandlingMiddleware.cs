using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ChatAPI.Middlewares
{
    public class ApiExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ApiExceptionHandlingMiddleware> _logger;

        public ApiExceptionHandlingMiddleware(RequestDelegate next, ILogger<ApiExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
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

        /// <summary>
        /// Own handle exception.
        /// </summary>
        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var problemDetails = new ValidationProblemDetails(new Dictionary<string, string[]>
                {{"Error", new[] {ex.Message}}})
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Title = "One or more validation errors occurred.",
                Status = (int) HttpStatusCode.BadRequest,
                Instance = context.Request.Path,
            };
            context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
            var result = JsonSerializer.Serialize(problemDetails);

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(result);
        }
    }
}