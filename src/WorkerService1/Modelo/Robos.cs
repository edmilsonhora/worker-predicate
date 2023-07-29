using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1.Modelo
{
    class Robo0
    {
        static int numerador = 0;
        public int Exceutar(Comandante c)
        {
            if (numerador < 20)
            {
                c.Pedido.Id = Numerador();
                Console.WriteLine($"Pedido Id: {c.Pedido.Id}");
                c.Pedido.ExecutaCodigo();
                Console.WriteLine($"Pedido Cod: {c.Pedido.Codigo}");
                return c.Pedido.Id;
            }
            return 0;

        }
        private static int Numerador()
        {
            return ++numerador;
        }
    }
    class Robo1
    {
        public bool ExecutarTarefa(Comandante c)
        {            
            
            System.Threading.Thread.Sleep(1000);
            string msg = $"Tarefa Robo1...{DateTimeOffset.Now}";
            Console.WriteLine(msg);
            c.Pedido.MarcarExecucao(msg);            
            return true;
        }
    }
    class Robo2
    {
        public bool ExecutarOutraTarefa(Comandante c)
        {
            string msg = $"Tarefa Robo2...{DateTimeOffset.Now}";
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(msg);
            c.Pedido.MarcarExecucao(msg);

            return true;
        }
    }
    class Robo3
    {
        public bool ExecutaTarefa3(Comandante c)
        {
            string msg = $"Tarefa Robo3...{DateTimeOffset.Now}";
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(msg);
            c.Pedido.MarcarExecucao(msg);

            return true;
        }
    }
    class Robo4
    {
        public bool Tarefa4(Comandante c)
        {
            string msg = $"Tarefa Robo4...{DateTimeOffset.Now}";
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(msg);
            c.Pedido.MarcarExecucao(msg);

            return true;
        }
    }
    class Robo5
    {
        public void Tarefa5(Comandante c)
        {
            string msg = $"Tarefa Robo5...{DateTimeOffset.Now}";
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(msg);
            c.Pedido.MarcarExecucao(msg);
            Console.WriteLine($" INSET {c.Pedido.SequenciaExecucao}");
                        
            c.ExecutarTarefas();

        }
    }
}
