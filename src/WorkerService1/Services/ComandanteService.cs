using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService1.Modelo;

namespace WorkerService1.Services
{
   public class ComandanteService:IComandanteService
    {
        private readonly ILogger<ComandanteService> _logger;
        public ComandanteService(ILogger<ComandanteService> logger)
        {
            _logger = logger;
        }
        public void Executar()
        {
            _logger.LogInformation("Inicio Execução Comandante");
            Comandante c = new Comandante();

            Thread t1 = new Thread(new ThreadStart(c.ExecutarTarefas));            
            Thread t2 = new Thread(new ThreadStart(c.ExecutarTarefas));            
            //Thread t3 = new Thread(new ThreadStart(c.ExecutarTarefas));            
            t2.Start();
            t1.Start();
            //t3.Start();

            //c.ExecutarTarefas();
        }
    }

   public interface IComandanteService
    {
        void Executar();
    }
}
