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
    public class CursoConexao : _ConexaoBD
    {

        //--------Método Gravar Cursos-------//
        public bool Gravar(Curso dado)
        {
            string instruncao = "Insert into tb_curso (Desc_Curso,CursoPreco) values(@Desc_Curso,@Curso_Preco)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Desc_Curso", dado.Desc_Curso);
            cmd.Parameters.AddWithValue("@Curso_Preco", dado.CursoPreco);
            return Executar(instruncao);
        }

        //----------Método Editar Cursos---------//
        public bool Editar(Curso dado)
        {
            string instruncao = "Update tb_curso set Desc_Curso=@Desc_Curso,Curso_Preco=@Curso_Preco where ID_Curso=@ID_Curso";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);
            cmd.Parameters.AddWithValue("@Desc_Curso", dado.Desc_Curso);
            cmd.Parameters.AddWithValue("@Curso_Preco", dado.CursoPreco);
            return Executar(instruncao);
        }

        //---------Método Eliminar Curso---------//
        public bool Eliminar(Curso dado)
        {
            string instruncao = "Delete tb_curso where ID_Curso=@ID_Curso";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);
            return Executar(instruncao);
        }

        //-----------Método Listar Cursos--------//
        public List<Curso> Listar()
        {
            List<Curso> List = new List<Curso>();
            string instruncao = "Select * from tb_curso order by Desc_Curso";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Curso dado = new Curso();
                    dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"].ToString());
                    dado.Desc_Curso = dr["Desc_Curso"].ToString();
                  dado.CursoPreco = Convert.ToDecimal(dr["Curso_Preco"].ToString());
                    List.Add(dado);

                }
            }
            return List;

        }

        //----------Método Pesquisar------------//
        public List<Curso> Pesquisar(string Desc_Curso)
        {
            List<Curso> List = new List<Curso>();
            string instruncao = "Select *from tb_curso where Desc_Curso like '%" + Desc_Curso + "%'";
            cmd.Parameters.AddWithValue("@Desc_Curso", Desc_Curso);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Curso dado = new Curso();
                    dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"]);
                    dado.Desc_Curso = dr["Desc_Curso"].ToString();
                    dado.CursoPreco = Convert.ToDecimal(dr["Curso_Preco"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }

        //---------Pesquisar AParir Do ID------//
        //----------Método Pesquisar------------//
        public List<Curso> PesquisarID(int ID_Curso)
        {
            List<Curso> List = new List<Curso>();
            string instruncao = "Select *from tb_curso where ID_Curso=@ID_Curso order by Desc_Curso";
            cmd.Parameters.AddWithValue("@ID_Curso", ID_Curso);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Curso dado = new Curso();
                    dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"]);
                    dado.Desc_Curso = dr["Desc_Curso"].ToString();
                    dado.CursoPreco = Convert.ToDecimal(dr["Curso_Preco"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }
    }
}