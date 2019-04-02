using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
    public class AlunoConexao : _ConexaoBD
    {
        //----------Para Gravar O Aluno-------------//
        public bool GravarFoto(Aluno dado)
        {
            string instruncao = "Insert into tb_aluno (Nome,BI_Aluno,Data_Nasc,ID_Sexo,ID_Nacional,Telefone_Aluno,Telefone_Encarregado,Municipio,Bairro,Rua,ID_Sala,ID_Turma,imgAluno) values(@Nome,@BI_Aluno,@Data_Nasc,@ID_Sexo,@ID_Nacional,@Telefone_Aluno,@Telefone_Encarregado,@Municipio,@Bairro,@Rua,@ID_Sala,@ID_Turma,@imgAluno)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Aluno);
            cmd.Parameters.AddWithValue("@BI_Aluno", dado.BI_Aluno);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.Data_Nasc);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@Telefone_Aluno", dado.Telefone_Aluno);
            cmd.Parameters.AddWithValue("@Telefone_Encarregado", dado.Telefone_Encarregado);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Sala", dado.ID_Sala);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);

            MySqlParameter paraFoto = new MySqlParameter("@imgAluno", MySqlDbType.Binary);
            paraFoto.Value = dado.foto;
            cmd.Parameters.Add(paraFoto);

            return Executar(instruncao);
        }

        public bool Gravar(Aluno dado)
        {
            string instruncao = "Insert into tb_aluno (Nome,BI_Aluno,Data_Nasc,ID_Sexo,ID_Nacional,Telefone_Aluno,Telefone_Encarregado,Municipio,Bairro,Rua,ID_Sala,ID_Turma) values(@Nome,@BI_Aluno,@Data_Nasc,@ID_Sexo,@ID_Nacional,@Telefone_Aluno,@Telefone_Encarregado,@Municipio,@Bairro,@Rua,@ID_Sala,@ID_Turma)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Aluno);
            cmd.Parameters.AddWithValue("@BI_Aluno", dado.BI_Aluno);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.Data_Nasc);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@Telefone_Aluno", dado.Telefone_Aluno);
            cmd.Parameters.AddWithValue("@Telefone_Encarregado", dado.Telefone_Encarregado);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Sala", dado.ID_Sala);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
            
            return Executar(instruncao);
        }
        //---------Para Editar O Aluno----------//
        public bool EditarFoto(Aluno dado)
        {
            string instruncao = "Update tb_aluno set Nome=@Nome,BI_Aluno=@BI_Aluno,Data_Nasc=@Data_Nasc,ID_Sexo=@ID_Sexo,ID_Nacional=@ID_Nacional,Telefone_Aluno=@Telefone_Aluno,Telefone_Encarregado=@Telefone_Encarregado," +
                " Municipio=@Municipio,Bairro=@Bairro,Rua=@Rua,ID_Sala=@ID_Sala,ID_Turma=@ID_Turma,imgAluno=@imgAluno where NProcesso=@NProcesso";

            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Aluno);
            cmd.Parameters.AddWithValue("@BI_Aluno", dado.BI_Aluno);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.Data_Nasc);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@Telefone_Aluno", dado.Telefone_Aluno);
            cmd.Parameters.AddWithValue("@Telefone_Encarregado", dado.Telefone_Encarregado);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Sala", dado.ID_Sala);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);

            MySqlParameter paraFoto = new MySqlParameter("@imgAluno", MySqlDbType.Binary);
            paraFoto.Value = dado.foto;
            cmd.Parameters.Add(paraFoto);

            return Executar(instruncao);
        }


        public bool Editar(Aluno dado)
        {
            string instruncao = "Update tb_aluno set Nome=@Nome,BI_Aluno=@BI_Aluno,Data_Nasc=@Data_Nasc,ID_Sexo=@ID_Sexo,ID_Nacional=@ID_Nacional,Telefone_Aluno=@Telefone_Aluno,Telefone_Encarregado=@Telefone_Encarregado," +
                " Municipio=@Municipio,Bairro=@Bairro,Rua=@Rua,ID_Sala=@ID_Sala,ID_Turma=@ID_Turma,imgAluno=@imgAluno where NProcesso=@NProcesso";

            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            cmd.Parameters.AddWithValue("@Nome", dado.Nome_Aluno);
            cmd.Parameters.AddWithValue("@BI_Aluno", dado.BI_Aluno);
            cmd.Parameters.AddWithValue("@Data_Nasc", dado.Data_Nasc);
            cmd.Parameters.AddWithValue("@ID_Sexo", dado.ID_Sexo);
            cmd.Parameters.AddWithValue("@ID_Nacional", dado.ID_Nacional);
            cmd.Parameters.AddWithValue("@Telefone_Aluno", dado.Telefone_Aluno);
            cmd.Parameters.AddWithValue("@Telefone_Encarregado", dado.Telefone_Encarregado);
            cmd.Parameters.AddWithValue("@Municipio", dado.Municipio);
            cmd.Parameters.AddWithValue("@Bairro", dado.Bairro);
            cmd.Parameters.AddWithValue("@Rua", dado.Rua);
            cmd.Parameters.AddWithValue("@ID_Sala", dado.ID_Sala);
            cmd.Parameters.AddWithValue("@ID_Turma", dado.ID_Turma);
            MySqlParameter paraFoto = new MySqlParameter("@imgAluno", MySqlDbType.Binary);
            paraFoto.Value = dado.foto;
            cmd.Parameters.Add(paraFoto);

            return Executar(instruncao);
        }
        //-----------Para Eliminar O Aluno------------------//
        public bool Eliminar(Aluno dado)
        {
            string instruncao = "Delete tb_aluno where NProcesso=@NProcesso";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            return Executar(instruncao);
        }
        //---------Isso Vai Pegar O Ultiimo Número de Processo E Leva Na matricúla------//
        public int MaxId()
        {

            string instruncao = "Select max(NProcesso) from tb_aluno";
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);
            dr.Read();
            if (dr != null)
            {
                return dr.GetInt32(0);
            }
            return -1;
        }
        //---------Listar Sem A View------------------------------//
        public List<Aluno> Listar()
        {
            List<Aluno> List = new List<Aluno>();
            string instruncao = "Select * from tb_aluno order by Nome";
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Aluno dado = new Aluno();
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.Nome_Aluno = dr["Nome"].ToString();
                    dado.BI_Aluno = dr["BI_Aluno"].ToString();
                    dado.Data_Nasc = Convert.ToDateTime(dr["Data_Nasc"].ToString());
                    dado.ID_Sexo = Convert.ToInt32(dr["ID_Sexo"].ToString());
                    dado.ID_Nacional = Convert.ToInt32(dr["ID_Nacional"].ToString());
                    dado.Telefone_Aluno = dr["Telefone_Aluno"].ToString();
                    dado.Telefone_Encarregado = dr["Telefone_Encarregado"].ToString();
                    dado.Municipio = dr["Municipio"].ToString();
                    dado.Bairro = dr["Bairro"].ToString();
                    dado.Rua = dr["Rua"].ToString();
                    dado.ID_Sala = Convert.ToInt32(dr["ID_Sala"].ToString());
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }
        //============Listar Todos Alunos Apartir da View===========//
         public List<AlunoView> ListarAll()
        {
            List<AlunoView> List = new List<AlunoView>();
            string instruncao = "Select * from viewAluno order by Nome";
            cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    AlunoView dado = new AlunoView();
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.Nome = dr["Nome"].ToString();
                    dado.BI_Aluno = dr["BI_Aluno"].ToString();
                    dado.Data_Nasc = Convert.ToDateTime(dr["Data_Nasc"].ToString());
                    dado.Sexo = dr["Sexo"].ToString();
                    dado.Nacionalidade = dr["Nacionalidade"].ToString();
                    dado.Telefone_Aluno = dr["Telefone_Aluno"].ToString();
                    dado.Telefone_Encarregado = dr["Telefone_Encarregado"].ToString();
                    dado.Municipio = dr["Municipio"].ToString();
                    dado.Bairro = dr["Bairro"].ToString();
                    dado.Rua = dr["Rua"].ToString();
                    dado.Sala = dr["Sala"].ToString();
                    dado.Turma = dr["Turma"].ToString();
                    dado.Classe = dr["Classe"].ToString();
                    dado.Curso = dr["Curso"].ToString();
                    dado.ID_Matricula = Convert.ToInt32(dr["ID_Matricula"].ToString());
                    List.Add(dado);
                }
            }
         
            return List;
        }
        //------------Para Listar Apartir Da Turma de Aluno---------//
         public List<AlunoView> ListarID(int ID_Turma)
         {
             List<AlunoView> List = new List<AlunoView>();
             string instruncao = "Select * from viewAluno where ID_Turma=@ID_Turma";
             cmd.CommandText = instruncao;
             cmd.Parameters.AddWithValue("@ID_Turma", ID_Turma);
            MySqlDataReader dr = Read(instruncao);

             if (dr != null)
             {
                 while (dr.Read())
                 {
                     AlunoView dado = new AlunoView();
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.Nome = dr["Nome"].ToString();
                    dado.BI_Aluno = dr["BI_Aluno"].ToString();
                    dado.Data_Nasc = Convert.ToDateTime(dr["Data_Nasc"].ToString());
                    dado.Sexo = dr["Sexo"].ToString();
                    dado.Nacionalidade = dr["Nacionalidade"].ToString();
                    dado.Telefone_Aluno = dr["Telefone_Aluno"].ToString();
                    dado.Telefone_Encarregado = dr["Telefone_Encarregado"].ToString();
                    dado.Municipio = dr["Municipio"].ToString();
                    dado.Bairro = dr["Bairro"].ToString();
                    dado.Rua = dr["Rua"].ToString();
                    dado.Sala = dr["Sala"].ToString();
                    dado.Turma = dr["Turma"].ToString();
                    dado.Classe = dr["Classe"].ToString();
                    dado.Curso = dr["Curso"].ToString();
                    dado.ID_Turma = Convert.ToInt32(dr["ID_Turma"].ToString());
                    dado.ID_Matricula = Convert.ToInt32(dr["ID_Matricula"].ToString());
                    List.Add(dado);
                 }
             }
             return List;
         }
         //============Pesquisar Pelo Nome Apartir da View===========//
         public List<AlunoView> ListarView(string Pesq)
         {
             List<AlunoView> List = new List<AlunoView>();
             string instruncao = "Select * from viewAluno where Nome Like '%" + Pesq + "%' Or BI_Aluno Like '%"+ Pesq +"%' Or NProcesso Like '%"+Pesq +"%' ORDER BY Nome";
             cmd.Parameters.AddWithValue("@Nome_Aluno", Pesq);
             cmd.CommandText = instruncao;
            MySqlDataReader dr = Read(instruncao);

             if (dr != null)
             {
                 while (dr.Read())
                 {
                     AlunoView dado = new AlunoView();
                    /*
                     1 ... Nome
                     2 ... BI
                     3....DataNascimento
                     4....Sexo
                     5...Nacionalidade
                     6...Telefone
                     7...TelefonePai
                     */
                     dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                     dado.Nome = dr["Nome"].ToString();
                     dado.BI_Aluno = dr["BI_Aluno"].ToString();
                     dado.Data_Nasc = Convert.ToDateTime(dr["Data_Nasc"].ToString());
                     dado.Sexo = dr["Sexo"].ToString();
                     dado.Nacionalidade = dr["Nacionalidade"].ToString();
                     dado.Telefone_Aluno = dr["Telefone_Aluno"].ToString();
                     dado.Telefone_Encarregado = dr["Telefone_Encarregado"].ToString();
                     dado.Municipio = dr["Municipio"].ToString();
                     dado.Bairro = dr["Bairro"].ToString();
                     dado.Rua = dr["Rua"].ToString();
                     dado.Sala = dr["Sala"].ToString();
                     dado.Turma = dr["Turma"].ToString();
                     dado.Classe = dr["Classe"].ToString();
                     dado.Curso = dr["Curso"].ToString();
                     dado.ID_Matricula = Convert.ToInt32(dr["ID_Matricula"].ToString());
                     List.Add(dado);
                 }
             }
             return List;
         }
 
         public List<BitmapImage> BitImg() {

            return new List<BitmapImage>();
         }
    }
}   