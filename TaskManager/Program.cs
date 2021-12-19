using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TaskManager
{
    public static class Program
    {
        private static IHost _host;

        public static void Main(string[] args)
        {
            // Init grpc
            _host = Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .Build();

            var serverAdvertizer = new ServerAdvertizer();
            serverAdvertizer.Start();
            _host.Run(); // block
            serverAdvertizer.Stop();
        }
    }
}