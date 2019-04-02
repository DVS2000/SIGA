using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
   public class View_Matricula
    {   
        public int NProcesso { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }
        public string Curso { get; set; }             
        public string Funcionario { get; set; }
        public DateTime Ano_Letivo { get; set; }
    }
}
