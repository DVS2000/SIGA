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
    public class NotaConexao : _ConexaoBD
    {
        public bool Gravar(Nota dado)
        {
            string instruncao = "Insert into tb_nota (NotaP1,NotaP2,NotaS1,NotaS2,NotaT1,NotaT2,Media,Resultado,ID_Disc,NProcesso) values(@NotaP1,@NotaP2,@Media,@Resultado,@ID_Disc,@NProcesso)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NotaP1", dado.NotaP1);
            cmd.Parameters.AddWithValue("@NotaP2", dado.NotaP2);
            cmd.Parameters.AddWithValue("@NotaS1", 0);
            cmd.Parameters.AddWithValue("@NotaS2", 0);
            cmd.Parameters.AddWithValue("@NotaT1", 0);
            cmd.Parameters.AddWithValue("@NotaT2", 0);
            cmd.Parameters.AddWithValue("@Media", dado.Media);
            cmd.Parameters.AddWithValue("@Resultado", dado.Resultado);
            cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            return Executar(instruncao);
        }

        public bool Editar(Nota dado)
        {
            string instruncao = "Update tb_nota set NotaS1=@NotaS1,NotaS2=@NotaS2,Media=@Media,Resultado=@Resultado WHERE NProcesso=@NProcesso";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NotaS1", dado.NotaS1);
            cmd.Parameters.AddWithValue("@NotaS2", dado.NotaS2);
            cmd.Parameters.AddWithValue("@Media", dado.Media);
            cmd.Parameters.AddWithValue("@Resultado", dado.Resultado);
           // cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            return Executar(instruncao);
        }

        public bool Final(Nota dado)
        {
            string instruncao = "Update tb_nota set NotaT1=@NotaT1,NotaT2=@NotaT2,Media=@Media,Resultado=@Resultado WHERE NProcesso=@NProcesso";
            cmd.CommandText = instruncao;

            cmd.Parameters.AddWithValue("@NotaT1", dado.NotaT1);
            cmd.Parameters.AddWithValue("@NotaT2", dado.NotaT2);
            cmd.Parameters.AddWithValue("@Media", dado.Media);
            cmd.Parameters.AddWithValue("@Resultado", dado.Resultado);
           // cmd.Parameters.AddWithValue("@ID_Disc", dado.ID_Disc);
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            return Executar(instruncao);
        }


        public bool Eliminar(Nota dado)
        {
            string instruncao = "Delete tb_nota where NProcesso=@NProcesso";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NProcesso", dado.ID_Nota);

            return Executar(instruncao);
        }


        public List<Nota> Listar()
        {
            List<Nota> List = new List<Nota>();
            string instruncao = "Select * from tb_nota";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Nota dado = new Nota();
                    dado.NotaP1 = float.Parse(dr["NotaP1"].ToString());
                    dado.NotaP2 = float.Parse(dr["NotaP2"].ToString());
                    dado.NotaS1 = float.Parse(dr["NotaS1"].ToString());
                    dado.NotaS2 = float.Parse(dr["NotaS2"].ToString());
                    dado.NotaT1 = float.Parse(dr["NotaT1"].ToString());
                    dado.NotaT2 = float.Parse(dr["NotaT2"].ToString());
                    dado.Media = float.Parse(dr["Media"].ToString());
                    dado.Resultado = dr["Resultado"].ToString();
                    dado.ID_Disc = Convert.ToInt32(dr["ID_Disc"].ToString());
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    List.Add(dado);

                }
            }
            return List;
        }

        //==================
        public List<NotaView> ListarView(int NProcesso)
        {
            List<NotaView> List = new List<NotaView>();
            string instruncao = "Select * from view_nota WHERE NProcesso=@NProcesso";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NProcesso", NProcesso);

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    NotaView dado = new NotaView();

                    dado.Disciplina = Convert.ToString(dr["Disciplina"]);
                    dado.NotaP1 = float.Parse(dr["NotaP1"].ToString());
                    dado.NotaP2 = float.Parse(dr["NotaP2"].ToString());
                    dado.NotaS1 = float.Parse(dr["NotaS1"].ToString());
                    dado.NotaS2 = float.Parse(dr["NotaS2"].ToString());
                    dado.NotaT1 = float.Parse(dr["NotaT1"].ToString());
                    dado.NotaT2 = float.Parse(dr["NotaT2"].ToString());
                    dado.Media = float.Parse(dr["Media"].ToString());
                    dado.Resultado = dr["Resultado"].ToString();
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    List.Add(dado);

                }
            }
            return List;
        }

        //=======================================
        public List<NotaView> Pesquisar(string Nome)
        {
            List<NotaView> List = new List<NotaView>();
            string instruncao = "Select * from view_nota where Nome Like '%" + Nome + "%'";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome", Nome);

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    NotaView dado = new NotaView();

                    dado.Disciplina = Convert.ToString(dr["Disciplina"]);
                    dado.NotaP1 = float.Parse(dr["NotaP1"].ToString());
                    dado.NotaP2 = float.Parse(dr["NotaP2"].ToString());
                    dado.NotaS1 = float.Parse(dr["NotaS1"].ToString());
                    dado.NotaS2 = float.Parse(dr["NotaS2"].ToString());
                    dado.NotaT1 = float.Parse(dr["NotaT1"].ToString());
                    dado.NotaT2 = float.Parse(dr["NotaT2"].ToString());
                    dado.Resultado = dr["Resultado"].ToString();
                    List.Add(dado);

                }
            }
            return List;
        }
    }
}
