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
   public class SexoConexao : _ConexaoBD
    {
       public List<Sexo> Listar()
       {
           List<Sexo> List = new List<Sexo>();
           string instruncao = "Select * from tb_sexo";
           cmd.CommandText = instruncao;

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Sexo dado = new Sexo();
                   dado.ID_Sexo = Convert.ToInt32(dr["ID_Sexo"].ToString());
                   dado.Desc_Sexo = dr["Desc_Sexo"].ToString();
                   List.Add(dado);
               }
           }
           return List;
       }
    }
}
