using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ConfiguringApps {

    public class Program {

        public static void Main(string[] args) {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup("ConfiguringApps")
                .Build();

            host.Run();
        }
    }
}
