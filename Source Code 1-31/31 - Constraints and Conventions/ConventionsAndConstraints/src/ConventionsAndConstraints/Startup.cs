using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ConventionsAndConstraints.Infrastructure;

namespace ConventionsAndConstraints {

    public class Startup {

        public void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<UserAgentComparer>();
            services.AddMvc().AddMvcOptions(options => {
                //options.Conventions.Add(new ActionNamePrefixAttribute("Do"));
                //options.Conventions.Add(new AdditionalActionsAttribute());
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
