using ChatAPI.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace ChatAPI.Extensions
{
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// Use custom error handler.
        /// </summary>
        public static IApplicationBuilder UseApiExceptionHandling(this IApplicationBuilder app)
            => app.UseMiddleware<ApiExceptionHandlingMiddleware>();
    }
}
