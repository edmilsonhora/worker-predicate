using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1.Modelo
{
    class Comandante
    {
        public Comandante()
        {
            Tarefa0 = new Robo0().Exceutar;
            Tarefa1 = new Robo1().ExecutarTarefa;
            Tarefa2 = new Robo2().ExecutarOutraTarefa;
            Tarefa3 = new Robo3().ExecutaTarefa3;
            Tarefa4 = new Robo4().Tarefa4;
            Tarefa5 = new Robo5().Tarefa5;
        }

        protected Func<Comandante, int> Tarefa0 { get; }
        protected Predicate<Comandante> Tarefa1 { get;  }
        protected Predicate<Comandante> Tarefa2 { get;  }
        protected Predicate<Comandante> Tarefa3 { get; }
        protected Predicate<Comandante> Tarefa4 { get; }
        protected Action<Comandante> Tarefa5 { get; }
        public Pedido Pedido { get; private set; }
        public int QtdExecusoes { get; set; } = 1;

        public void ExecutarTarefas()
        {           
            object _lock = new object();

            lock (_lock)
            {
                Pedido = new Pedido();//Poderia esta vindo do banco;
                int id = Tarefa0.Invoke(this);
            }

           

            var executouT1 = Tarefa1.Invoke(this);

            var executouT2 = Tarefa2.Invoke(this);

            var executouT3 = Tarefa3.Invoke(this);

            var executouT4 = Tarefa4.Invoke(this);

            Tarefa5.Invoke(this);
        }
    }
}

        
    

