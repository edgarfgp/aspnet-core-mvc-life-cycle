using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace NetCoreMvcMiddleware.Auth
{
    public class LocalAuthorize : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Request.Host.Value.Contains("localhost"))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
