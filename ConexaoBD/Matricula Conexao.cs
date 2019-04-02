using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
    public class Matricula_Conexao : _ConexaoBD
    {
        public bool Gravar(Matricula dado)
        {
            string instruncao = "Insert into tb_matricula (ID_Classe,ID_Curso,NProcesso,Data_Matricula,ID_Usuario) values(@ID_Classe,@ID_Curso,@NProcesso,@Data_Matricula,@ID_Usuario)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
            cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);
            cmd.Parameters.AddWithValue("@Data_Matricula", dado.Ano_Matricula);
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            cmd.Parameters.AddWithValue("@ID_Usuario", dado.ID_Usuario);
            return Executar(instruncao);

        }

        public bool Editar(Matricula dado)
        {
            string instruncao = "Update tb_matricula set ID_Classe=@ID_Classe,ID_Curso=@ID_Curso,ID_Usuario=@ID_Usuario where ID_Matricula=@ID_Matricula";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Matricula", dado.ID_Matricula);
            cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
            cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);
           // cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            cmd.Parameters.AddWithValue("@ID_Usuario", dado.ID_Usuario);
           // cmd.Parameters.AddWithValue("@Id_Turma", dado.Id_Turma);
            return Executar(instruncao);

        }

        public bool Eliminar(Matricula dado)
        {
            string instruncao = "Delete tb_matricula where ID_Matricula=@ID_Matricula";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Matricula", dado.ID_Matricula);
            return Executar(instruncao);

        }

        public List<Matricula> Listar()
        {
            List<Matricula> List = new List<Matricula>();
            string instruncao = "Select * from tb_matricula";
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Matricula dado = new Matricula();
                    dado.ID_Matricula = Convert.ToInt32(dr["ID_Matricula"].ToString());
                    dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"].ToString());
                    dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"].ToString());
                    dado.Ano_Matricula = Convert.ToDateTime(dr["Data_Matricula"].ToString());
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.ID_Usuario = Convert.ToInt32(dr["ID_Usuario"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }


        //-------Pesquisar Apartir do ID---------//
        public List<Matricula> PesquisarMatri(int NProcesso)
        {
            List<Matricula> List = new List<Matricula>();
            string instruncao = "Select * from tb_Matricula where NProcesso=@NProcesso";
            cmd.Parameters.AddWithValue("@NProcesso", NProcesso);
            cmd.CommandText = instruncao;       
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Matricula dado = new Matricula();
                    dado.ID_Matricula = Convert.ToInt32(dr["ID_Matricula"].ToString());
                    dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"].ToString());
                    dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"].ToString());
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.Ano_Matricula = Convert.ToDateTime(dr["Data_Matricula"].ToString());
                    dado.ID_Usuario = Convert.ToInt32(dr["ID_Usuario"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }

        //==============================================
        public List<View_Matricula> ListarView()
        {
            List<View_Matricula> Lista = new List<View_Matricula>();
            string Instruncao = "SELECT * FROM viewmatricual order by Nome";
            cmd.CommandText = Instruncao;

            MySqlDataReader dr = Read(Instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    View_Matricula dado = new View_Matricula();                   
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.Nome = dr["Nome"].ToString();
                    dado.Classe = dr["Desc_Classe"].ToString();
                    dado.Curso = dr["Desc_Curso"].ToString();
                    dado.Ano_Letivo = Convert.ToDateTime(dr["Data_Matricula"].ToString());
                    dado.Funcionario = dr["Funcionario"].ToString();
                    Lista.Add(dado);
                }
            }
            return Lista;
        }

    }
}