using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MicroCommerce.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseUrls("http://179.109.47.138:5000");
                });
    }
}
