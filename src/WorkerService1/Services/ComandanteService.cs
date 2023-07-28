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
            _logger.LogInformation("Inicio Execução");            

            Comandante c = new Comandante();
            c.Tarefa0 = new Robo0().Exceutar;
            c.Tarefa1 = new Robo1().ExecutarTarefa;
            c.Tarefa2 = new Robo2().ExecutarOutraTarefa;
            c.Tarefa3 = new Robo3().ExecutaTarefa3;
            c.Tarefa4 = new Robo4().Tarefa4;

            _logger.LogInformation("Inicio Execução Comandante");
            c.ExecutarTarefas();
        }
    }

   public interface IComandanteService
    {
        void Executar();
    }
}
