using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Cities.Models;

namespace Cities {

    public class Startup {

        public void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IRepository, MemoryRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app) {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            //app.Map("/mvcapp", appBuilder => {
            //    appBuilder.UseStatusCodePages();
            //    appBuilder.UseDeveloperExceptionPage();
            //    appBuilder.UseStaticFiles();
            //    appBuilder.UseMvcWithDefaultRoute();
            //});
        }
    }
}
