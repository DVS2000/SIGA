using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Atributos;

namespace ConexaoBD
{
   public class TurnoConexao : _ConexaoBD
    {
        //-----------Método Gravar Turnos-----------//
        public bool Gravar(Turno dado)
        {
            string instruncao = "Insert into tb_turno (Desc_Turno) values(@Desc_Turno)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Desc_Turno", dado.Desc_Turno);
            return Executar(instruncao);
        }

        //---------Método Editar Turnos---------//
        public bool Editar(Turno dado)
        {
            string instruncao = "Update tb_turno set Desc_Turno=@Desc_Turno where ID_Turno=@ID_Turno";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Turno", dado.ID_Turno);
            cmd.Parameters.AddWithValue("@Desc_Turno", dado.Desc_Turno);
            return Executar(instruncao);
        }

        //------------Método Eliminar Turnos-----------//
        public bool Eliminar(Turno dado)
        {
            string instruncao = "Delete tb_turno where ID_Turno=@ID_Turno";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Turno", dado.ID_Turno);
            return Executar(instruncao);
        }

        //----------Listar Turnos--------//
        public List<Turno> Listar()
        {
            List<Turno> list = new List<Turno>();
            string instruncao = "Select * from tb_turno";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Turno dado = new Turno();
                    dado.ID_Turno = Convert.ToInt32(dr["ID_Turno"].ToString());
                    dado.Desc_Turno = dr["Desc_Turno"].ToString();
                    list.Add(dado);
                }
            }
            return list;
        }

    }
}
