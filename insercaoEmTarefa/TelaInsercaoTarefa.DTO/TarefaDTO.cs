using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInsercaoTarefa.DTO
{
    public class TarefaDTO
    {
        public int Codigo { get; set; }
        public int Task { get; set; }
        public string Cliente { get; set; }
        public int Urgencia { get; set; }
        public decimal Tempo { get; set; }
        public string Versao { get; set; }
        public int Motivo { get; set; }
        public int TaskOrigem { get; set; }
        public DateTime Data { get; set; }
        public string Obs { get; set; }
        public int Area { get; set; }
        public int Time { get; set; }
        public string Atendente { get; set; }
        public string Trello { get; set; }


    }
}
