using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModelValidation {

    public class Startup {

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc().AddMvcOptions(opts => {
                opts.ModelBindingMessageProvider.ValueMustNotBeNullAccessor =
                        value => "Please enter a value";
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
