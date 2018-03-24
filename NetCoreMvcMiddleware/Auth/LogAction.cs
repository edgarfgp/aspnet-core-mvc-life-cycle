using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcMiddleware.Auth
{
    public class LogAction : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action is Executig");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Action has Executed");
        }
    }
}
