using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FrontControllerExample.Middleware
{
    public class FrontControllerMiddleware
    {
        private readonly RequestDelegate _next;
        public FrontControllerMiddleware(RequestDelegate next) => _next = next;
        public async Task Invoke(HttpContext ctx)
        {
            // авторизація, логування
            if (!ctx.User.Identity.IsAuthenticated)
            {
                ctx.Response.Redirect("/Home/Login");
                return;
            }
            await _next(ctx);
        }
    }
}
