using Contracts;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Filter
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        private ILoggerManager _logger;
        public AuthorizationFilter(ILoggerManager loggerManager)
        {
            _logger = loggerManager;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _logger.LogInfo("authorization");
            var session = context.HttpContext.Session;
            var userModel = session.Id;
            //throw new NotImplementedException();
        }
    }
}
