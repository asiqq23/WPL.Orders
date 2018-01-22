using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WPL.Orders.Middlewares
{
    public class ServerNameMiddleware
    {
        private readonly RequestDelegate _next;

        public ServerNameMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.Headers.Add("ServerName", Environment.MachineName);

            return this._next(context);
        }
    }
}