using Microsoft.AspNetCore.Routing.Constraints;

namespace Session02ASp.Net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();

            ////Static Segment
            //app.MapGet("/", () => "Hello World!");


            ////Variable Segment
            //app.MapGet("/{name}", async context =>
            //{
            //    var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {Name}");
            //});
            ////Mixed Segment
            //app.MapGet("/X{name}", async context =>
            //{
            //    await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");
            //});


            //app.MapControllerRoute(
            //    name: "Default", 
            //    pattern: "{Controller}/{action}/{Id?}", 
            //    defaults: new {action = "Index", controller = "Movies"},
            //    constraints: new {Id = @"\d{2}"}
            //    );

            app.UseStaticFiles();
            app.MapControllerRoute(
                name : "Default",
                pattern: "{controller=Home}/{action=Index}/{Id:regex(^\\d{{2}}$)?}"
                );


            app.Run();
        }
    }
}
