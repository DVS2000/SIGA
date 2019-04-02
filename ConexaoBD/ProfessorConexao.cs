using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
    public class ProfessorConexao : _ConexaoBD
    {
        //-------Para Gravar O Professor--------//
        public bool GravarFoto(Professor dado)
        {
            string instruncao = "Insert into tb_professor (Nome,BI_Prof,Data_Nasc,ID_Sexo,ID_Nacional,ID_Estado,Telefone_Prof,Municipio,Bairro,Rua,ID_Disc,ID_Turma,imgProf)"
                + "Values(@Nome,@BI_Prof,@Data_Nasc,@ID_Sexo,@ID_Nacional,@ID_Estado,@Telefone_Prof,@Municipio,@Bairro,@Rua,@ID_Disc,@ID_Turma,@imgProf)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Professor);
            cmd.Parameters.AddWithValue("@BI_Prof", dado.BI_Professor);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.DataNasc_Professor);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@ID_Estado", dado.ID_Estado);
            cmd.Parameters.AddWithValue("@Telefone_Prof", dado.Telefone_Professor);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);

            MySqlParameter pFoto = new MySqlParameter("@imgProf", MySqlDbType.Binary);
            pFoto.Value = dado.foto;
            cmd.Parameters.Add(pFoto);
            return Executar(instruncao);
        }

        public bool Gravar(Professor dado)
        {
            string instruncao = "Insert into tb_professor (Nome,BI_Prof,Data_Nasc,ID_Sexo,ID_Nacional,ID_Estado,Telefone_Prof,Municipio,Bairro,Rua,ID_Disc,ID_Turma,)"
                + "Values(@Nome,@BI_Prof,@Data_Nasc,@ID_Sexo,@ID_Nacional,@ID_Estado,@Telefone_Prof,@Municipio,@Bairro,@Rua,@ID_Disc,@ID_Turma)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Professor);
            cmd.Parameters.AddWithValue("@BI_Prof", dado.BI_Professor);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.DataNasc_Professor);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@ID_Estado", dado.ID_Estado);
            cmd.Parameters.AddWithValue("@Telefone_Prof", dado.Telefone_Professor);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
           
            return Executar(instruncao);
        }

        //----------Para Editar O Aluno-----------//

        public bool EditarFoto(Professor dado)
        {
            string instruncao = "Update tb_professor set Nome=@Nome,BI_Prof=@BI_Prof,ID_Turma=@ID_Turma,Data_Nasc=@Data_Nasc,ID_Nacional=@ID_Nacional,ID_Sexo=@ID_Sexo,ID_Disc=@ID_Disc,Telefone_Prof=@Telefone_Prof,Municipio=@Municipio,Bairro=@Bairro,Rua=@Rua" +
                ",ID_Estado=@ID_Estado,imgProf=@imgProf where ID_Professor=@ID_Professor";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Professor);
            cmd.Parameters.AddWithValue("@BI_Prof", dado.BI_Professor);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.DataNasc_Professor);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@Telefone_Prof", dado.Telefone_Professor);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
            cmd.Parameters.AddWithValue(@"ID_Estado", dado.ID_Estado);

            MySqlParameter pFoto = new MySqlParameter("@imgProf", MySqlDbType.Binary);
            pFoto.Value = dado.foto;
            cmd.Parameters.Add(pFoto);
            return Executar(instruncao);
        }


        public bool Editar(Professor dado)
        {
            string instruncao = "Update tb_professor set Nome=@Nome,BI_Prof=@BI_Prof,ID_Turma=@ID_Turma,Data_Nasc=@Data_Nasc,ID_Nacional=@ID_Nacional,ID_Sexo=@ID_Sexo,ID_Disc=@ID_Disc,Telefone_Prof=@Telefone_Prof,Municipio=@Municipio,Bairro=@Bairro,Rua=@Rua" +
                ",ID_Estado=@ID_Estado,imgProf=@imgProf where ID_Professor=@ID_Professor";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Professor);
            cmd.Parameters.AddWithValue("@BI_Prof", dado.BI_Professor);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.DataNasc_Professor);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@Telefone_Prof", dado.Telefone_Professor);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
            cmd.Parameters.AddWithValue(@"ID_Estado", dado.ID_Estado);

            MySqlParameter pFoto = new MySqlParameter("@imgProf", MySqlDbType.Binary);
            pFoto.Value = null;
            cmd.Parameters.Add(pFoto);
            return Executar(instruncao);
        }

        //---------Para Eliminar O Professor-----------------//
        public bool Eliminar(Professor dado)
        {
            string instruncao = "Delete tb_professor where ID_Professor=@ID_Professor";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Professor", dado.ID_Professor);
            return Executar(instruncao);
        }

        //---------Para Listar Os Professor------------//
        public List<Professor> Listar()
        {
            List<Professor> List = new List<Professor>();
            string instruncao = "Select * from tb_professor";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Professor dado = new Professor();
                    dado.ID_Professor = Convert.ToInt16(dr["ID_Professor"].ToString());
                    dado.Nome_Professor = Convert.ToString(dr["Nome"]);
                    dado.BI_Professor = Convert.ToString(dr["BI_Prof"]);
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    dado.DataNasc_Professor = Convert.ToDateTime(dr["Data_Nasc"].ToString());
                    dado.ID_Nacional = Convert.ToInt32(dr["ID_Nacional"].ToString());
                    dado.ID_Sexo = Convert.ToInt32(dr["ID_Sexo"].ToString());
                    dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                    dado.ID_Estado = Convert.ToInt32(dr["ID_Estado"].ToString());
                    dado.Municipio = Convert.ToString(dr["Municipio"]);
                    dado.Bairro = Convert.ToString(dr["Bairro"]);
                    dado.Rua = Convert.ToString(dr["Rua"]);
                    List.Add(dado);
                }
            }
            return List;
        }


        //---------Para Listar Os Professor------------//
        public List<ProfessorView> ListarView()
        {
            List<ProfessorView> List = new List<ProfessorView>();
            string instruncao = "Select * from viewprofessor ORDER BY Nome";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    ProfessorView dado = new ProfessorView();
                    dado.ID_Professor = Convert.ToInt16(dr["ID_Professor"].ToString());
                    dado.Nome = Convert.ToString(dr["Nome"]);
                    dado.BI_Prof = Convert.ToString(dr["BI_Prof"]);
                    dado.Data_Nasc = Convert.ToDateTime(Convert.ToDateTime(dr["Data_Nasc"].ToString()).ToShortDateString());
                    dado.Sexo = Convert.ToString(dr["Sexo"]);
                    dado.Nacionalidade = Convert.ToString(dr["Nacionalidade"]);
                    dado.Estado = Convert.ToString(dr["Estado"]);
                    dado.Telefone_Professor = Convert.ToString(dr["Telefone_Prof"]);
                    dado.Municipio = Convert.ToString(dr["Municipio"]);
                    dado.Bairro = Convert.ToString(dr["Bairro"]);
                    dado.Rua = Convert.ToString(dr["Rua"]);
                    dado.Disciplina = Convert.ToString(dr["Disciplina"]);
                    dado.Classe = Convert.ToString(dr["Classe"]);
                    dado.Curso = Convert.ToString(dr["Curso"]);
                    dado.Turma = Convert.ToString(dr["Turma"]);
                    List.Add(dado);
                }
            }
            return List;
        }



        //--------Pesquisar View---------//
        public List<ProfessorView> PesquisarProf(string Nome_Professor)
        {
            List<ProfessorView> List = new List<ProfessorView>();
            string instruncao = "Select * from viewProfessor where Nome like'%" + Nome_Professor + "%' order by Nome";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome_Professor", Nome_Professor);

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    ProfessorView dado = new ProfessorView();
                    dado.ID_Professor = Convert.ToInt16(dr["ID_Professor"].ToString());
                    dado.Nome = Convert.ToString(dr["Nome"]);
                    dado.BI_Prof = Convert.ToString(dr["BI_Prof"]);
                    dado.Data_Nasc = Convert.ToDateTime(dr["Data_Nasc"].ToString());
                    dado.Sexo = Convert.ToString(dr["Sexo"]);
                    dado.Nacionalidade = Convert.ToString(dr["Nacionalidade"]);
                    dado.Estado = Convert.ToString(dr["Estado"]);
                    dado.Telefone_Professor = Convert.ToString(dr["Telefone_Prof"]);
                    dado.Municipio = Convert.ToString(dr["Municipio"]);
                    dado.Bairro = Convert.ToString(dr["Bairro"]);
                    dado.Rua = Convert.ToString(dr["Rua"]);
                    dado.Disciplina = Convert.ToString(dr["Disciplina"]);
                    dado.Classe = Convert.ToString(dr["Classe"]);
                    dado.Curso = Convert.ToString(dr["Curso"]);
                    dado.Turma = Convert.ToString(dr["Turma"]);
                    List.Add(dado);
                }
            }
            return List;
        }
    }
}
