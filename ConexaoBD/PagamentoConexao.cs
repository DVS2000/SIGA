using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using ConexaoBD;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
    public class PagamentoConexao : _ConexaoBD
    {
        public bool Gravar(Pagamento dado)
        {
            string instruncao = "Insert into tb_pagamento (NProcesso,ID_Mes,Valor,Data) values(@NProcesso,@ID_Mes,@Valor,@Data)";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            cmd.Parameters.AddWithValue("@ID_Mes", dado.ID_Mes);
            cmd.Parameters.AddWithValue("@Valor", dado.Valor);
            cmd.Parameters.AddWithValue("@DataPagamento", dado.Data);
            return Executar(instruncao);
        }

        //------Para Editar------------//
        public bool Editar(Pagamento dado)
        {
            string instruncao = "Update tb_pagamento set NProcesso=@NProcesso,ID_Mes=@ID_Mes,Valor=@Valor where ID_Pagamento=@ID_Pagamento";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Pagamento", dado.ID_Pagamento);
            cmd.Parameters.AddWithValue("@NProcesso", dado.NProcesso);
            cmd.Parameters.AddWithValue("@ID_Mes", dado.ID_Mes);
            cmd.Parameters.AddWithValue("@Valor", dado.Valor);
            return Executar(instruncao);
        }

        //------Para Eliminar------------//
        public bool Eliminar(Pagamento dado)
        {
            string instruncao = "Delete tb_pagamento where ID_Pagamento=@ID_Pagamento";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@ID_Pagamento", dado.ID_Pagamento);
            return Executar(instruncao);
        }

        //-----Para Listar------------//
        public List<Pagamento> Listar()
        {
            List<Pagamento> List = new List<Pagamento>();
            string instruncao = "Select * from tb_pagamento";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Pagamento dado = new Pagamento();
                    dado.ID_Pagamento = Convert.ToInt32(dr["ID_Pagamento"].ToString());
                    dado.NProcesso = Convert.ToInt32(dr["NProcesso"].ToString());
                    dado.ID_Mes = Convert.ToInt32(dr["ID_Mes"].ToString());
                    dado.Valor = Convert.ToDecimal(dr["Valor"].ToString());
                    dado.Data = Convert.ToDateTime(dr["DataPagamento"].ToString());
                    List.Add(dado);
                }
            }
            return List;
        }


        //--------Para Listar Com a View--------//
        public List<PagamentoView> ListarView()
        {
            List<PagamentoView> List = new List<PagamentoView>();
            string instruncao = "Select * from View_Pagamento";
            cmd.CommandText = instruncao;

            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    PagamentoView dado = new PagamentoView();
                    dado.ID_Pagamento = Convert.ToInt32(dr["ID_Pagamento"].ToString());
                    dado.Nome = Convert.ToString(dr["Nome_Aluno"]);
                    dado.Mes = Convert.ToString(dr["Mes"]);
                    dado.Valor = Convert.ToDecimal(dr["Valor"].ToString());
                    dado.Data = Convert.ToDateTime(dr["Data"].ToString());
                    dado.Turma = Convert.ToString(dr["Turma"]);
                    dado.Classe = Convert.ToString(dr["Classe"]);
                    dado.Curso = Convert.ToString(dr["Curso"]);
                    List.Add(dado);
                }
            }
            return List;
        }
        //===============================
        public List<PagamentoView> Pesquisar(string Nome_Aluno)
        {
            List<PagamentoView> List = new List<PagamentoView>();
            string instruncao = "Select * from View_Pagamento where Nome_Aluno Like '%" + Nome_Aluno + "%'";
            cmd.CommandText = instruncao;
            cmd.Parameters.AddWithValue("@Nome_Aluno", Nome_Aluno);
            MySqlDataReader dr = Read(instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    PagamentoView dado = new PagamentoView();
                    dado.ID_Pagamento = Convert.ToInt32(dr["ID_Pagamento"].ToString());
                    dado.Nome = Convert.ToString(dr["Nome_Aluno"]);
                    dado.Mes = Convert.ToString(dr["Mes"]);
                    dado.Valor = Convert.ToDecimal(dr["Valor"].ToString());
                    dado.Data = Convert.ToDateTime(dr["Data"].ToString());
                    dado.Turma = Convert.ToString(dr["Turma"]);
                    dado.Classe = Convert.ToString(dr["Classe"]);
                    dado.Curso = Convert.ToString(dr["Curso"]);
                    List.Add(dado);
                }
            }
            return List;
        }
    }
}
