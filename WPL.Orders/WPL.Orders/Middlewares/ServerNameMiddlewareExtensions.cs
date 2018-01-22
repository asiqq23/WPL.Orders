using Microsoft.AspNetCore.Builder;

namespace WPL.Orders.Middlewares
{
    public static class ServerNameMiddlewareExtensions
    {
        public static IApplicationBuilder UseServerName(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ServerNameMiddleware>();
        }
    }
}