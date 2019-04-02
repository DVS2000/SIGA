using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class Matricula
    {
        public int ID_Matricula { get; set; }
        public int ID_Curso { get; set; }
        public int ID_Classe { get; set; }
        public DateTime Ano_Matricula { get; set; }
        public int NProcesso { get; set; }
        public int ID_Usuario { get; set; }
    }
}
