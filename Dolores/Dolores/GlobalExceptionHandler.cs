namespace Dolores
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
    using Application.Exceptions;
    using FluentValidation;
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;

    public class GlobalExceptionHandler
	{
        private readonly RequestDelegate _next;

        public GlobalExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (System.Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                object response = null;
                var statusCode = StatusCodes.Status500InternalServerError;

                if (ex is ForbiddenUseCaseExecutionException forbidden)
                {
                    statusCode = StatusCodes.Status403Forbidden;
                    response = new { message = forbidden.Message };
                }

                if (ex is EntityNotFoundException)
                {
                    statusCode = StatusCodes.Status404NotFound;
                }

                if (ex is UseCaseConflictException conflictEx)
                {
                    statusCode = StatusCodes.Status409Conflict;
                    response = new { message = conflictEx.Message };
                }

                if (ex is ValidationException e)
                {
                    statusCode = StatusCodes.Status422UnprocessableEntity;
                    response = new
                    {
                        errors = e.Errors.Select(x => new
                        {
                            property = x.PropertyName,
                            error = x.ErrorMessage
                        }).ToList()
                    };
                }


                httpContext.Response.StatusCode = statusCode;
                if (response != null)
                {
                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
                }
            }
        }
    }
}
