using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class AlunoDisc_Conexao : _ConexaoBD
    {
       //---------Para Gravar -------//
       public bool Gravar(AlunoDisc dado)
       {
           string Instruncao = "Insert into tb_alunodisc (NProcesso,ID_Disc) values(@NProcesso,@ID_Disc)";
           cmd.CommandText = Instruncao;
           cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
           cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
           return Executar(Instruncao);
       }

       //---------Para Editar-----//
       public bool Editar(AlunoDisc dado)
       {
           string Instruncao = "Update tb_alunodisc set NProcesso=@NProcesso,ID_Disc=@ID_Disc where ID_AlunoDisc=@ID_AlunoDisc";
           cmd.CommandText = Instruncao;
           //*Nn Is Necessario**cmd.Parameters.AddWithValue("ID_AlunoDisc", dado.ID_AlunoDisc);
           cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
           cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
           return Executar(Instruncao);
       }


       //---------Para Eliminar-----//
       public bool Eliminar(AlunoDisc dado)
       {
           string Instruncao = "Delete tb_alunodisc where ID_AlunoDisc=@ID_AlunoDisc";
           cmd.CommandText = Instruncao;
           cmd.Parameters.AddWithValue("ID_AlunoDisc", dado.ID_AlunoDisc);
           return Executar(Instruncao);
       }

       //---------Para Listar-----//
       public List<AlunoDisc> Listar()
       {
           List<AlunoDisc> List = new List<AlunoDisc>();
           string Instruncao = "Select* from tb_alunodisc";
           cmd.CommandText = Instruncao;

           MySqlDataReader dr = Read(Instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   AlunoDisc dado = new AlunoDisc();
                   dado.ID_AlunoDisc = Convert.ToInt32(dr["ID_AlunoDisc"].ToString());
                   dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                   dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                   List.Add(dado);
               }
           }
           return List;
           
       }
    }
}
