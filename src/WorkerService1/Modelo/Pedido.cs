using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1.Modelo
{
    public class Pedido
    {


        public int Id { get; set; }
        public string Codigo { get; set; }
        public string SequenciaExecucao { get; set; } = string.Empty;

        public void ExecutaCodigo()
        {
            Codigo = $"{Id.ToString().PadLeft(6, '0')}";
        }

        public void MarcarExecucao(string execucao)
        {
            SequenciaExecucao += $" => {execucao} | [{Codigo}]";
        }
    }
}
