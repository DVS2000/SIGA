using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class UsuariosConexao : _ConexaoBD
    {
        public bool Gravar(Usuarios dado)
        {
            string instruncao = "Insert into tb_usario (Nome,Senha,Nivel) values(@Nome,@Senha,@Nivel)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome", dado.Nome);
            cmd.Parameters.AddWithValue("@Senha", dado.Senha);
            cmd.Parameters.AddWithValue("@Cargo", dado.Cargo);

            return Executar(instruncao);
        }

        public bool Editar(Usuarios dado)
        {
            string instruncao = "Update tb_usario set Nome=@Nome,Senha=@Senha,Cargo=@Cargo where ID_Usuario=@ID_Usuario";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Usuario", dado.ID_Usuarios);
            cmd.Parameters.AddWithValue("@Nome", dado.Nome);
            cmd.Parameters.AddWithValue("@Senha", dado.Senha);
            cmd.Parameters.AddWithValue("@Cargo", dado.Cargo);

            return Executar(instruncao);
        }

        public bool Eliminar(Usuarios dado)
        {
            string instruncao = "Delete tb_usario where ID=@ID";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Usuario", dado.ID_Usuarios);

            return Executar(instruncao);
        }

        public List<Usuarios> Listar()
        {
            List<Usuarios> List = new List<Usuarios>();
            string instrunco = "Select * from tb_usario";
            cmd.CommandText = instrunco;

            MySqlDataReader dr = Read(instrunco);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Usuarios dado = new Usuarios();
                    dado.ID_Usuarios = Convert.ToInt32(dr["ID_Usuario"].ToString());
                    dado.Nome = dr["Nome"].ToString();
                    dado.Senha = dr["Senha"].ToString();
                    dado.Cargo = dr["Nivel"].ToString();
                    List.Add(dado);
                }
            }
            return List;
        }
    }
}
