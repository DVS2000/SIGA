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
   public class ClasseConexao : _ConexaoBD
    {

        //--------Método Gravar Classe-------//
        public bool Gravar(Classe dado)
        {
            string Instruncao = "Insert into tb_classe (Desc_Classe,Preco) values(@Desc_Classe,@Preco)";
            cmd.CommandText = Instruncao;
            cmd.Parameters.AddWithValue("@Desc_Classe", dado.Desc_Classe);
            cmd.Parameters.AddWithValue("@Preco", dado.ClassePreco);
            return Executar(Instruncao);
        }

        //----------Médo Editar Classe--------//
        public bool Editar(Classe dado)
        {
            string Instruncao = "Update tb_Classe set Desc_Classe=@Desc_Classe, Preco=@Preco where ID_Classe=@ID_Classe";
            cmd.CommandText = Instruncao;
            cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
            cmd.Parameters.AddWithValue("@Desc_Classe", dado.Desc_Classe);
            cmd.Parameters.AddWithValue("@Preco", dado.ClassePreco);
            return Executar(Instruncao);
        }

        //--------Método Eliminar Classe--------------//
        public bool Eliminar(Classe dado)
        {
            string Instruncao = "Delete tb_Classe where ID_Classe=@ID_Classe";
            cmd.CommandText = Instruncao;
            cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
            return Executar(Instruncao);
        }

        //--------Método Listar Classes------//

        public List<Classe> Listar()
        {
            List<Classe> List = new List<Classe>();
            string Instruncao = "Select * from tb_classe order by Desc_Classe";

            MySqlDataReader dr = Read(Instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Classe dado = new Classe();
                    dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"].ToString());
                    dado.Desc_Classe = dr["Desc_Classe"].ToString();
                    dado.ClassePreco = Convert.ToDecimal(dr["Preco"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }
       
       //----------Método Pesquisar-----------//
        public List<Classe> Pesquisar(string Desc_Classe)
        {
            List<Classe> List = new List<Classe>();
            string instruncao = "Select *from tb_classe where Desc_Classe like '%" + Desc_Classe + "%' order by Desc_Classe";
            cmd.Parameters.AddWithValue("@Desc_Classe", Desc_Classe);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {

                while (dr.Read())
                {
                    Classe dado = new Classe();
                    dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"]);
                    dado.Desc_Classe = dr["Desc_Classe"].ToString();
                    dado.ClassePreco = Convert.ToDecimal(dr["Preco"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }


       //--------------Pesquisar Pelo ID-----------//

        public List<Classe> PesquisarID(int ID_Classe)
        {
            List<Classe> List = new List<Classe>();
            //string instruncao = "Select *from tb_Classe where ID_Classe like '%" + ID_Classe + "%' order by Desc_Classe";
            string instruncao = "Select *from tb_classe where ID_Classe=@ID_Classe order by Desc_Classe";
            cmd.Parameters.AddWithValue("@ID_Classe", ID_Classe);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {

                while (dr.Read())
                {
                    Classe dado = new Classe();
                    dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"]);
                    dado.Desc_Classe = dr["Desc_Classe"].ToString();
                    dado.ClassePreco = Convert.ToDecimal(dr["Preco"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }

    }
}
