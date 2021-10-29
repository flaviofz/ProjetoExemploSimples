using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjetoExemplo.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                 await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(
            HttpContext httpContext,
            Exception exception
        )
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return Task.CompletedTask;
        }
    }
}