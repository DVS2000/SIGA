using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
    public class TurmaConexao : _ConexaoBD
    {
        //---------------Método Gravar Turma-------------//
        public bool Gravar(Turma dado)
        {
            string instruncao = "Insert into tb_turma (Desc_Turma,ID_Turno,ID_Classe,ID_Curso) values(@Desc_Turma,@ID_Turno,@ID_Classe,@ID_Curso)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Desc_Turma", dado.Desc_Turma);
            cmd.Parameters.AddWithValue("@ID_Turno", dado.ID_Turno);
            cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
            cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);

            return Executar(instruncao);
        }

        //-----------------Método Editar Turma--------------//
        public bool Editar(Turma dado)
        {
            string instruncao = "Update tb_turma set Desc_Turma=@Desc_Turma,ID_Turno=@ID_Turno,ID_Classe=@ID_Classe,ID_Curso=@ID_Curso where ID_Turma=@ID_Turma";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
            cmd.Parameters.AddWithValue("@Desc_Turma", dado.Desc_Turma);
            cmd.Parameters.AddWithValue("@ID_Turno", dado.ID_Turno);
            cmd.Parameters.AddWithValue("@ID_Classe", dado.ID_Classe);
            cmd.Parameters.AddWithValue("@ID_Curso", dado.ID_Curso);

            return Executar(instruncao);
        }

        //------------------Método Eliminar Turma---------------//
        public bool Eliminar(Turma dado)
        {
            string instruncao = "Delete tb_turma where ID_Turma=@ID_Turma";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);

            return Executar(instruncao);
        }

        //---------Método Listar Turmas-------------------//
        public List<TurmaView> Listar()
        {
            List<TurmaView> list = new List<TurmaView>();
            string instrucao = "select *from viewTurma order by Classe Desc";

            MySqlDataReader dr = Read(instrucao);

            if (dr != null)
            {

                while (dr.Read())
                {
                    TurmaView dado = new TurmaView();
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    dado.Turma =Convert.ToString(dr["Turma"]);
                    dado.Classe = dr["Classe"].ToString();
                    dado.Curso = dr["Curso"].ToString();
                    dado.Turno = dr["Turno"].ToString();

                    list.Add(dado);
                }
            }
            return list;
       }
        //-----------Pesquisar Turmas------//
        public List<TurmaView> Pesquisar(string Desc_Turma)
        {
            List<TurmaView> List = new List<TurmaView>();
            string instruncao = "Select *from tb_turma where Desc_Turma like '%" + Desc_Turma + "%'";
            cmd.Parameters.AddWithValue("@Desc_Turma", Desc_Turma);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);
            if (dr != null)
            {
                while (dr.Read())
                {
                    TurmaView dado = new TurmaView();
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    dado.Turma = dr["Desc_Turma"].ToString();
                    dado.Turno = dr["Turno"].ToString();
                    dado.Classe = dr["Classe"].ToString();
                    dado.Curso = dr["Curso"].ToString();
                    List.Add(dado);
                }
            }
            return List;
        }

        public List<TurmaView> ListarView(string Desc_Turma)
        {
            List<TurmaView> List = new List<TurmaView>();
            string instruncao = "Select *from viewTurma where Desc_Turma like '%" + Desc_Turma + "%'";
            cmd.Parameters.AddWithValue("@Desc_Turma", Desc_Turma);
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);
            if (dr != null)
            {
                while (dr.Read())
                {
                    TurmaView dado = new TurmaView();
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    dado.Turma = dr["Desc_Turma"].ToString(); 
                    dado.Turno = dr["Turno"].ToString();
                    dado.Classe = dr["Classe"].ToString();
                    dado.Curso = dr["Curso"].ToString();
                    List.Add(dado);
                }
            }
            return List;
        }

        public List<Turma> ListarT()
        {
            List<Turma> List = new List<Turma>();
            string instruncao = "Select *from tb_turma";
            
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);
            if (dr != null)
            {
                while (dr.Read())
                {
                    Turma dado = new Turma();
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    dado.Desc_Turma = dr["Desc_Turma"].ToString();
                    dado.ID_Turno = Convert.ToInt32(dr["ID_Turno"].ToString());
                    dado.ID_Classe = Convert.ToInt32(dr["ID_Classe"].ToString());
                    dado.ID_Curso = Convert.ToInt32(dr["ID_Curso"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }
    }
}