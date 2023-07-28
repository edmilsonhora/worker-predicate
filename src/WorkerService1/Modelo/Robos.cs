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
        public int Exceutar(Comandante c)
        {
            object _lock = new object();

            lock (_lock)
            {
                c.Pedido.Id = ++numerador;
                Console.WriteLine($"Pedido Id: {c.Pedido.Id}");
                c.Pedido.ExecutaCodigo();
                Console.WriteLine($"Pedido Cod: {c.Pedido.Codigo}");
                return c.Pedido.Id;
            }
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
        public bool Tarefa4(Comandante c)
        {
            Console.WriteLine($"Tarefa Robo4...{DateTimeOffset.Now}");

            System.Threading.Thread.Sleep(1000);
            return true;
        }
    }
    class Robo5
    {
        public void Tarefa5(Comandante c)
        {
            Console.WriteLine($"Tarefa Robo5...{DateTimeOffset.Now}");
            Console.WriteLine($"Pedido Cod: {c.Pedido.Codigo}");

            System.Threading.Thread.Sleep(1000);

            //if (5 > c.QtdExecusoes++)
            //{
            c.ExecutarTarefas();
            // }
        }
    }
}
