using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1.Modelo
{
    class Robo0
    {
        int numerador = 0;
        public int Exceutar(Comandante c, Pedido pedido)
        {            
            pedido.Id = ++numerador;
            Console.WriteLine($"Pedido Id: {pedido.Id}");
            pedido.ExecutaCodigo();
            Console.WriteLine($"Pedido Cod: {pedido.Codigo}");
            return pedido.Id;
        }        
    }
    class Robo1
    {
        public bool ExecutarTarefa(Comandante c)
        {
            Console.WriteLine($"Tarefa Robo1...{DateTimeOffset.Now}");
            System.Threading.Thread.Sleep(1000);
            return true;
        }
    }
    class Robo2
    {
        public bool ExecutarOutraTarefa(Comandante c)
        {
            Console.WriteLine($"Tarefa Robo2...{DateTimeOffset.Now}");
            System.Threading.Thread.Sleep(1000);
            return true;
        }
    }
    class Robo3
    {
        public bool ExecutaTarefa3(Comandante c)
        {
            Console.WriteLine($"Tarefa Robo3...{DateTimeOffset.Now}");
            System.Threading.Thread.Sleep(1000);
            return true;
        }
    }
    class Robo4
    {
        public bool Tarefa4(Comandante c, Pedido pedido)
        {
            Console.WriteLine($"Tarefa Robo4...{DateTimeOffset.Now}");
            Console.WriteLine($"Pedido Cod: {pedido.Codigo}");
            System.Threading.Thread.Sleep(1000);
            c.ExecutarTarefas();
            return true;
        }
    }
}
