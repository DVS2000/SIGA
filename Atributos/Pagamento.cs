using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class PagamentoView
    {
        public int ID_Pagamento { get; set; }
        public string Nome { get; set; }
        public string Mes { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Turma { get; set; }
        public string Classe { get; set; }
        public string Curso { get; set; }
    }
   public class Pagamento
    {
        public int ID_Pagamento { get; set; }
        public int NProcesso { get; set; }
        public int ID_Mes { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
