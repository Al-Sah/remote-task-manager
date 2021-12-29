using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TaskManager.Core;

namespace TaskManager
{
    public static class Program
    {
        private static IHost _host;

        public static void Main(string[] args)
        {
            ForbiddenProcessesManager.GetInstance(); // Creation
            // Init grpc
            _host = Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .Build();

            var serverAdvertizer = new ServerAdvertizer();
            serverAdvertizer.Start();
            _host.Run(); // block
            ForbiddenProcessesManager.GetInstance().Stop();
            serverAdvertizer.Stop();
        }
    }
}