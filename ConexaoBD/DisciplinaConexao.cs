using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class DisciplinaConexao : _ConexaoBD
    {
       //----------Gravar A Disciplina---------//
       public bool Gravar(Disciplina dado)
       {
           string instruncao = "Insert into tb_disciplina(NomeCurto,NomeCompleto) values(@NomeCurto,@NomeCompleto)";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@NomeCurto", dado.NomeCurto);
           cmd.Parameters.AddWithValue("@NomeCompleto", dado.NomeCompleto);
           return Executar(instruncao);
       }

       //--------Editar A Disciplina---------//
       public bool Editar(Disciplina dado)
       {
           string instruncao = "Update tb_disciplina set NomeCurto=@NomeCurto,NomeCompleto=@NomeCompleto where ID_Disc=@ID_Disc";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
           cmd.Parameters.AddWithValue("@NomeCurto", dado.NomeCurto);
           cmd.Parameters.AddWithValue("@NomeCompleto", dado.NomeCompleto);
           return Executar(instruncao);
       }

       //-------Para Eliminar A Disciplina-----//
       public bool Eliminar(Disciplina dado)
       {
           string instruncao = "Delete tb_disciplina where ID_Disc=@ID_Disc";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
           return Executar(instruncao);
       }

       //----------MaxID para Pegar O Ultimo ID---------//
       public int MaxID()
       {
           string instruncao = "Select Max(ID_Disc) from  tb_disciplina";
           cmd.CommandText = instruncao;
               MySqlDataReader dr = Read(instruncao);
           dr.Read();
           if (dr != null)
	          {
	          	 return dr.GetInt32(0);
	          }
           return -1;
       }

       //---------Para Listar A Disciplina--------------//
       public List<Disciplina> Listar()
       {
           List<Disciplina> List = new List<Disciplina>();
           string instruncao = "Select *  from tb_disciplina order by NomeCurto";
           cmd.CommandText = instruncao;

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Disciplina dado = new Disciplina();
                   dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                   dado.NomeCurto = Convert.ToString(dr["NomeCurto"]);
                   dado.NomeCompleto = Convert.ToString(dr["NomeCompleto"]);
                   List.Add(dado);
               }         
           }
           return List;          
       }

       //---------Para Pesquisar A Disciplina--------------//
       public List<Disciplina> Pesquisar(string NomeCompleto)
       {
           List<Disciplina> List = new List<Disciplina>();
           string instruncao = "Select *  from tb_disciplina where NomeCompleto like '%" + NomeCompleto + "%'order by NomeCurto";
           cmd.CommandText = instruncao;
           cmd.Parameters.AddWithValue("@NomeCompleto", NomeCompleto);

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Disciplina dado = new Disciplina();
                   dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                   dado.NomeCurto = Convert.ToString(dr["NomeCurto"]);
                   dado.NomeCompleto = Convert.ToString(dr["NomeCompleto"]);
                   List.Add(dado);
               }
           }
           return List;
       }

    }
}
