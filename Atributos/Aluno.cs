using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class AlunoView
    {
        public int NProcesso { get; set; }
        public string Nome { get; set; }
        public string BI_Aluno { get; set; }       
        public string Sexo { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Telefone_Aluno { get; set; }
        public string Telefone_Encarregado { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Sala { get; set; }
        public string Turma { get; set; }
        public string Classe { get; set; }
        public string Curso { get; set; }
        public int ID_Matricula { get; set; }

        public int ID_Turma { get; set; }

    }
   public class Aluno
    {
        public int NProcesso { get; set; }
        public string Nome_Aluno { get; set; }
        public string BI_Aluno { get; set; }
        public DateTime Data_Nasc { get; set; }
        public int ID_Sexo { get; set; }
        public int ID_Nacional { get; set; }
        public string Telefone_Aluno { get; set; }
        public string Telefone_Encarregado { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int ID_Sala { get; set; }
        public int ID_Turma { get; set; }

        public byte[] foto { get; set; }

    }
}
