using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcMiddleware.Middleware
{
    public class LoggingMiddleware
    {
        private RequestDelegate _nextDelegate;

        public LoggingMiddleware(RequestDelegate next) => _nextDelegate = next;

        public async Task Invoke(HttpContext context)
        {
            Debug.WriteLine("=== Loading Before===");
            await _nextDelegate.Invoke(context);
            Debug.WriteLine("=== Loading After===");
        }
    }
}
