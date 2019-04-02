using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class TurmaView
    {
        public int ID_Turma { get; set; }
        public string Turma { get; set; }
        public string Classe { get; set; }
        public string Curso { get; set; }
        public string Turno { get; set; }
    }
  public  class Turma
    {
        public int ID_Turma { get; set; }
        public string Desc_Turma { get; set; }
        public int ID_Classe { get; set; }
        public int ID_Curso { get; set; }
        public int ID_Turno { get; set; }
    }
}
