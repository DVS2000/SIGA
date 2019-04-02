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
   public class Disc_ProfConexao : _ConexaoBD
    {
       //-------Para Guardar---------//
       public bool Gravar(Disc_Prof dado)
       {
           string instruncao = "Insert into tb_disc_prof (ID_Professor,ID_Disc) values(@ID_Professor,@ID_Disc)";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
           cmd.Parameters.AddWithValue("@ID_Dis", dado.ID_Disc);
           return Executar(instruncao);
       }

       //-------Para Editar---------//
       public bool Editar(Disc_Prof dado)
       {
           string instruncao = "Update tb_Disc_Prof set ID_Professor=@ID_Professor,ID_Disc=@ID_Disc where ID_Disc_Prof=@ID_Disc_Prof";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc_Prof", dado.ID_Disc_Prof);
           cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
           cmd.Parameters.AddWithValue("@ID_Dis", dado.ID_Disc);
           return Executar(instruncao);
       }

       //-------Para Eliminar---------//
       public bool Eliminar(Disc_Prof dado)
       {
           string instruncao = "Delete tb_Disc_Prof where ID_Disc_Prof=@ID_Disc_Prof";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc_Prof", dado.ID_Disc_Prof);
           return Executar(instruncao);
       }

       //--------Para Listar---------//
       public List<Disc_Prof> Listar()
       {
           List<Disc_Prof> List = new List<Disc_Prof>();
           string instruncao = "Select * from tb_disc_prof";
           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Disc_Prof dado = new Disc_Prof();
                   dado.ID_Disc_Prof = Convert.ToInt32(dr["ID_Disc_Prof"].ToString());
                   dado.ID_Professor = Convert.ToInt32(dr["ID_Professor"].ToString());
                   dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                   List.Add(dado);
               }
           }
           return List;
       }

    }
}
