using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites {
    public class Startup {
        
        public void ConfigureServices(IServiceCollection services) {
            services.AddTransient<IRepository, EFRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, 
                IHostingEnvironment env, ILoggerFactory loggerFactory) {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
