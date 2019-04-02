using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class ProfessorView
    {
        public int ID_Professor { get; set; }
        public string Nome { get; set; }
        public string BI_Prof { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidade { get; set; }
        public string Estado { get; set; }
        public string Telefone_Professor { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Disciplina { get; set; }
        public string Classe { get; set; }
        public string Curso { get; set; }
        public string Turma { get; set; }     

    }
   public class Professor
    {
        public int ID_Professor { get; set; }
        public string Nome_Professor { get; set; }
        public string BI_Professor { get; set; }
        public DateTime DataNasc_Professor { get; set; }
        public string Telefone_Professor { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int ID_Estado {get; set; }
        public int ID_Sexo { get; set; }
        public int ID_Nacional { get; set; }
        public int ID_Disc { get; set; }
        public int ID_Turma { get; set; }
        public byte[] foto { get; set; }

    }
}
