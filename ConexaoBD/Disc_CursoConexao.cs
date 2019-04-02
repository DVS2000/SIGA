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
   public class Disc_CursoConexao :_ConexaoBD
    {
       //-------Para Gravar---------//
       public bool Gravar(Disc_Curso dado)
       {
           string instruncao = "Insert into tb_disc_curso (ID_Disc,ID_Curso,ID_Classe) values(@ID_Disc,@ID_Curso,@ID_Classe)";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
           cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);
           cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
           return Executar(instruncao);
       }

       //-----Para Editar----------//
       public bool Editar(Disc_Curso dado)
       {
           string instruncao = "Update tb_disc_curso set ID_Disc=@ID_Disc,ID_Curso=@ID_Curso,ID_Classe=@ID_Classe where ID_Disc_Curso=@ID_Disc_Curso";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc_Curso", dado.ID_Disc_Curso);
           cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
           cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);
           cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
           return Executar(instruncao);
       }

       //--------Para Eliminar----------//
       public bool Eliminar(Disc_Curso dado)
       {
           string instruncao = "Delete tb_disc_curso where ID_Disc_Curso=@ID_Disc_Curso";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc_Curso", dado.ID_Disc_Curso);          
           return Executar(instruncao);
       }

       //-----Para Listar-----------//
       public List<Disc_Curso> Listar()
       {
           List<Disc_Curso> List = new List<Disc_Curso>();
           string instruncao = "Select * from tb_disc_curso";
           cmd.CommandText = instruncao;

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Disc_Curso dado = new Disc_Curso();
                   dado.ID_Disc_Curso = Convert.ToInt32(dr["ID_Disc_Curso"].ToString());
                   dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                   dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"].ToString());
                   dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"].ToString());
                   List.Add(dado);
               }
           }
           return List;
       }

       //---------Para Listar As Classe Com A View----------//
       public List<Disc_Curso_View> Listar_View()
       {
           List<Disc_Curso_View> List = new List<Disc_Curso_View>();
           string instruncao = "Select * from View_Disc_Curso order by Nome"; /*CRIAR VIEW DEPOIS*/
           cmd.CommandText = instruncao;

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Disc_Curso_View dado = new Disc_Curso_View();
                   dado.ID_Disc_Curso = Convert.ToInt32(dr["ID_Disc_Curso"].ToString());
                   dado.Nome = dr["Nome"].ToString();
                   dado.Abreviacao = dr["Abreviação"].ToString();
                   dado.Curso = dr["Curso"].ToString();
                   dado.Classe = dr["Classe"].ToString();
                   dado.Disc_ID = Convert.ToInt32(dr["ID_Disc"].ToString());
                   List.Add(dado);
               }
           }
           return List;
       }
      
    }
}
