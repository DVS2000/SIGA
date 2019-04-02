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
   public class EstadoConexao : _ConexaoBD
    {
       public List<Estado> Listar()
       {
           List<Estado> List = new List<Estado>();
           string instruncao = "Select * from tb_estado";
           cmd.CommandText = instruncao;

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Estado dado = new Estado();
                   dado.ID_Estado = Convert.ToInt32(dr["ID_Estado"].ToString());
                   dado.Desc_Estado = dr["Desc_Estado"].ToString();
                   List.Add(dado);
               }
           }
           return List;
       }
    }
}
