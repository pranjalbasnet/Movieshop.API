using System;

namespace Movieshop.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("middleware 1 - request \n");
            //    next();
            //    await context.Response.WriteAsync("middleware 1 - response \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("midddleware 2 - request \n");
            //    await context.Response.WriteAsync("middleware 2 - response \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("middleware 3 - request");
            //});

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting();

            //app.UseEndpoints(endpoints => {
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("welcome to dot net core");
            //    });
            //});

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}