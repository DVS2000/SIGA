using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class SalaConexao : _ConexaoBD
    {
       //-----------Método Grvar Sala------------//
        public bool Gravar(Sala dado)
        {
            string instruncao = "Insert into tb_sala (Desc_Sala) values(@Desc_Sala)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Desc_Sala", dado.Desc_Sala);
            return Executar(instruncao);
        }

       //------------Método Editar Sala---------//
        public bool Editar(Sala dado)
        {
            string instruncao = "Update tb_sala set Desc_Sala=@Desc_Sala where ID_Sala=@ID_Sala";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Sala", dado.ID_Sala);
            cmd.Parameters.AddWithValue("@Desc_Sala", dado.Desc_Sala);
            return Executar(instruncao);
        }
        
       //-----------Método Eliminar Sala----------//
        public bool Eliminar(Sala dado)
        {
            string instruncao = "Delete tb_sala where ID_Sala=@ID_Sala";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Sala", dado.ID_Sala);
            return Executar(instruncao);
        }
       //------Para Listar As Salas--------//
        public List<Sala> Listar()
        {
            List<Sala> List = new List<Sala>();
            string instruncao = "Select * from tb_sala order by Desc_Sala";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Sala dado = new Sala();
                    dado.ID_Sala = Convert.ToInt32(dr["ID_Sala"].ToString());
                    dado.Desc_Sala = dr["Desc_Sala"].ToString();
                    List.Add(dado);
                }
            }
            return List;
        }
       //-----------Pesquisar Salas--------//
        public List<Sala> Pesquisar(string Desc_Sala) 
        {
            List<Sala> List = new List<Sala>();
            string instruncao = "Select *from tb_sala where Desc_Sala like '%" + Desc_Sala + "%'";
            cmd.Parameters.AddWithValue("@Desc_Sala", Desc_Sala);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);
            if (dr != null)
            {
                while (dr.Read())
                {
                    Sala dado = new Sala();
                    dado.ID_Sala = Convert.ToInt32(dr["ID_Sala"]);
                    dado.Desc_Sala = Convert.ToString(dr["Desc_Sala"]);
                    List.Add(dado);
                }
            }
            return List;
        }

    }
}
