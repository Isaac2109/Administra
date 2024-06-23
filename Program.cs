using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Administra
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
                    webBuilder.UseStartup<Startup>(); // Aqui definimos o uso do Startup criado
                });
    }
}
