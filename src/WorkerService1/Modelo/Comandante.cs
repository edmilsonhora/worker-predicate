using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1.Modelo
{
    class Comandante
    {
        public Func<Comandante, Pedido, int> Tarefa0 { get; set; }
        public Predicate<Comandante> Tarefa1 { get; set; }
        public Predicate<Comandante> Tarefa2 { get; set; }
        public Predicate<Comandante> Tarefa3 { get; set; }
        public Func<Comandante, Pedido, bool> Tarefa4 { get; set; }

        public void ExecutarTarefas()
        {
            var pedido = new Pedido();//Poderia esta vindo do banco;

            int id = Tarefa0.Invoke(this, pedido);

            var executouT1 = Tarefa1.Invoke(this);

            var executouT2 = Tarefa2.Invoke(this);

            var executouT3 = Tarefa3.Invoke(this);

            var executouT4 = Tarefa4.Invoke(this, pedido);
        }
    }
}

        
    

