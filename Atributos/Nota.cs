using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class NotaView
    {
        public string Disciplina { get; set; }
        public float NotaP1 { get; set; }
        public float NotaP2 { get; set; }
        public float NotaS1 { get; set; }
        public float NotaS2 { get; set; }
        public float NotaT1 { get; set; }
        public float NotaT2 { get; set; }
        public float Media { get; set; }
        public string Resultado { get; set; }
        public int NProcesso { get; set; }

    }
    public class Nota
    {
        public int ID_Nota { get; set; }
        public int NProcesso { get; set; }
        public int ID_Disc { get; set; }
        public float NotaP1 { get; set; }
        public float NotaP2 { get; set; }
        public float NotaS1 { get; set; }
        public float NotaS2 { get; set; }
        public float NotaT1 { get; set; }
        public float NotaT2 { get; set; }
        public float Media { get; set; }     
        public string Resultado { get; set; }

    }
}
