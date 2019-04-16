using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KB.Middleware
{
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// config custom exception handler
        /// </summary>
        public static void ConfigGlobalExceptionHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionMiddleware>();
        }

    }
}
