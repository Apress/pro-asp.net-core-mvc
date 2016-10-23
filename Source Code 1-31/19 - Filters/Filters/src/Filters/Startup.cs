using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Filters.Infrastructure;

namespace Filters {

    public class Startup {

        public void ConfigureServices(IServiceCollection services) {
            services.AddScoped<IFilterDiagnostics, DefaultFilterDiagnostics>();
            services.AddScoped<TimeFilter>();
            services.AddScoped<ViewResultDiagnostics>();
            services.AddScoped<DiagnosticsFilter>();
            services.AddMvc().AddMvcOptions(options => {
                options.Filters.Add(new
                    MessageAttribute("This is the Globally-Scoped Filter"));
            });
        }

        public void Configure(IApplicationBuilder app) {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
