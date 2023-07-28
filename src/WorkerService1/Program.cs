using WorkerService1.Services;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddSingleton<IComandanteService, ComandanteService>();
                })
                .Build();

            host.Run();
        }
    }
}