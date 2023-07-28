using WorkerService1.Services;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IComandanteService _service;

        public Worker(ILogger<Worker> logger, IComandanteService service)
        {
            _logger = logger;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(500, stoppingToken);
            _service.Executar();                
           
        }
    }
}