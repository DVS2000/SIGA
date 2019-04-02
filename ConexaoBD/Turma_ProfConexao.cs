using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class Turma_ProfConexao : _ConexaoBD
    {
       //--------Para Gravar--------//
       public bool Gravar(Turma_Prof dado)
       {
           string instruncao = "Insert into tb_turmaProf (ID_Turma,ID_Professor) values(@ID_Turma,@ID_Professor)";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
           cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
           return Executar(instruncao);
       }

       //--------Para Editar--------//
       public bool Editar(Turma_Prof dado)
       {
           string instruncao = "Update tb_turmaProf set ID_Turma=@ID_Turma,ID_Professor=@ID_Professor where ID_TurmaProf=@ID_TurmaProf";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_TurmaProf", dado.ID_Turma_Prof);
           cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
           cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
           return Executar(instruncao);
       }

       //------Para Eliminar--------//
       public bool Eliminar(Turma_Prof dado)
       {
           string instruncao = "Delete tb_turmaProf where ID_Turma_Prof=@ID_Turma_Prof";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_TurmaProf", dado.ID_Turma_Prof);
           return Executar(instruncao);
       }
       
       //-----Para Listar----------//
       public List<Turma_Prof> Listar()
       {
           List<Turma_Prof> List = new List<Turma_Prof>();

           string instruncao = "Select * from tb_turmaProf";
           cmd.CommandText = instruncao;
           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Turma_Prof dado = new Turma_Prof();
                   dado.ID_Turma_Prof = Convert.ToInt32(dr["ID_TurmaProf"].ToString());
                   dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                   dado.ID_Professor = Convert.ToInt32(dr["ID_Professor"].ToString());
                   List.Add(dado);
               }
           }
           return List;
       }
    }
}
