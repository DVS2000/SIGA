using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class Disc_Curso_View
    {
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
        public int ID_Disc_Curso { get; set; }
        public string Curso { get; set; }
        public string Classe { get; set; }
        public int Disc_ID { get; set; }
        
    }
   public class Disc_Curso
    {
        public int ID_Disc_Curso { get; set; }
        public int ID_Curso { get; set; }
        public int ID_Classe { get; set; }
        public int ID_Disc { get; set; }
    }
}
