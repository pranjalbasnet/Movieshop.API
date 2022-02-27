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
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

        }
    }
}