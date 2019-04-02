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
   public class NacionalidadeConexao : _ConexaoBD
    {
        //--------Método Gravar Nacionalidade--------//
        public bool Gravar(Nacionalidade dado)
        {
            string instruncao = "Insert into tb_nacionalidade (Desc_Nacional) values(@Desc_Nacional)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Desc_Nacional", dado.Desc_Nacional);
            return Executar(instruncao);
        }

        //--------Método Editar Nacionalidade--------//
        public bool Editar(Nacionalidade dado)
        {
            string instruncao = "Update tb_nacionalidade set Desc_Nacional=@Desc_Nacional where ID_Nacional=@ID_Nacional";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@Desc_Nacional", dado.Desc_Nacional);
            return Executar(instruncao);
        }

        //--------Método Eliminar Nacionalidade--------//
        public bool Eliminar(Nacionalidade dado)
        {
            string instruncao = "Delete tb_nacionalidade where ID_Nacional=@ID_Nacional";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            return Executar(instruncao);
        }

        public List<Nacionalidade> Listar()
        {
            List<Nacionalidade> List = new List<Nacionalidade>();
            string instruncao = "Select * from tb_nacionalidade order by Desc_Nacional";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Nacionalidade dado = new Nacionalidade();
                    dado.ID_Nacional = Convert.ToInt32(dr["ID_Nacional"].ToString());
                    dado.Desc_Nacional = dr["Desc_Nacional"].ToString();
                    List.Add(dado);
                }
            }
            return List;
        }

        public List<Nacionalidade> Pesquisar(string Desc_Nacional)
        {
            List<Nacionalidade> List = new List<Nacionalidade>();
            string instruncao = "Select *from tb_Nacionalidade where Desc_Nacional like '%" + Desc_Nacional + "%'";
            cmd.Parameters.AddWithValue("@Desc_Nacional", Desc_Nacional);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Nacionalidade dado = new Nacionalidade();
                    dado.ID_Nacional = Convert.ToInt32(dr["ID_Nacional"].ToString());
                    dado.Desc_Nacional = dr["Desc_Nacional"].ToString();
                    List.Add(dado);
                }
            }
            return List;
        }
    }
}
