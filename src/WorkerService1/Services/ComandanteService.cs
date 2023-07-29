using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService1.Modelo;

namespace WorkerService1.Services
{
    public class ComandanteService : IComandanteService
    {
        private readonly ILogger<ComandanteService> _logger;
        public ComandanteService(ILogger<ComandanteService> logger)
        {
            _logger = logger;
        }
        public void ExecutarAsync()
        {
            int numThreds = 8;
            _logger.LogInformation("Inicio Execução Comandante");            

            Task[] myTasks = new Task[numThreds];

            for (int i = 0; i < numThreds; i++)
            {
                Comandante c = new Comandante();
                myTasks[i] = Task.Factory.StartNew(() => c.ExecutarTarefas());
                System.Threading.Thread.Sleep(1000);
            }

            Task.WaitAll(myTasks);
        }
    }

    public interface IComandanteService
    {
        void ExecutarAsync();
    }
}
