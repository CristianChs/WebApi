
namespace WebApi.Middlewares
{
    public class TimeMiddlewares
    {
        readonly RequestDelegate next;//invoca el middlewares

        public TimeMiddlewares(RequestDelegate nextRequest)
        {
            next=nextRequest;
        }

        //siempre hay que popner este metodo Invoke para un middleware
        public async Task  Invoke(HttpContext context)
        {
            await next(context);
            if(context.Request.Query.Any(p=>p.Key=="TIME"))
            {
                await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
            }            
        }
    }

    //CLASE PARA USAR EL MIDDLEWARE
    public static class TimeMiddlewareExtension
    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMiddlewares>();
        }
    }
    
}
