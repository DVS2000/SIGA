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
   public class MesConexao : _ConexaoBD
    {
       public List<Mes> Listar()
       {
           List<Mes> List = new List<Mes>();
           string instruncao = "Select * from tb_mes";
           cmd.CommandText = instruncao;

           MySqlDataReader dr = Read(instruncao);

           if (dr != null)
           {
               while (dr.Read())
               {
                   Mes dado = new Mes();
                   dado.ID_Mes = Convert.ToInt32(dr["ID_Mes"].ToString());
                   dado.Desc_Mes = dr["Desc_Mes"].ToString();
                   List.Add(dado);
               }
           }
           return List;
       }
    }
}
