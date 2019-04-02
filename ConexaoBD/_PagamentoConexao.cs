using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atributos;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class _PagamentoConexao : _ConexaoBD
    {
        public void Update(_Pagamento dados)
        {
            string Instruncao = "UPDATE Pagamento SET NProcesso=@NProcesso,Janeiro=@Janeiro,Fevereiro=@Fevereiro,Marco=@Marco,Abril=@Abril,Maio=@Maio,Junho=@Junho,Julho=@Julho,Agosto=@Agosto,Setembro=@Setembro,Outubro=@Outubro,Novembro=@Novembro,Dezembro=@Dezembro WHERE ID_Pagamento =@ID_Pagamento";
            cmd.Parameters.AddWithValue("@NProcesso", dados.NProcesso);
            cmd.Parameters.AddWithValue("@Janeiro", dados.Janeiro);
            cmd.Parameters.AddWithValue("@Fevereiro", dados.Fevereiro);
            cmd.Parameters.AddWithValue("@Marco", dados.Marco);
            cmd.Parameters.AddWithValue("@Abril", dados.Abril);
            cmd.Parameters.AddWithValue("@Maio", dados.Maio);
            cmd.Parameters.AddWithValue("@Junho", dados.Junho);
            cmd.Parameters.AddWithValue("@Julho", dados.Julho);
            cmd.Parameters.AddWithValue("@Agosto", dados.Agosto);
            cmd.Parameters.AddWithValue("@Setembro", dados.Setembro);
            cmd.Parameters.AddWithValue("@Outubro", dados.Outubro);
            cmd.Parameters.AddWithValue("@Novembro", dados.Novembro);
            cmd.Parameters.AddWithValue("@Dezembro", dados.Dezembro);
            Executar(Instruncao);
        }


        public List<_Pagamento_View> Listar()
        {
            List<_Pagamento_View> Dados = new List<_Pagamento_View>();
            string Instruncao = "SELECT * FROM view_pagamento ORDER By Nome";
            cmd.CommandText = Instruncao;
            MySqlDataReader dr = Read(Instruncao);

            if (dr != null)
            {
                while (dr.Read())
                {
                    _Pagamento_View Inf = new _Pagamento_View();
                    Inf.ID_Pagamento = Convert.ToInt32(dr["ID_Pagamento"].ToString());
                    Inf.Nome = dr["Nome"].ToString();
                    Inf.Janeiro = dr["Janeiro"].ToString();
                    Inf.Fevereiro = dr["Fevereiro"].ToString();
                    Inf.Marco = dr["Marco"].ToString();
                    Inf.Abril = dr["Abril"].ToString();
                    Inf.Maio = dr["Maio"].ToString();
                    Inf.Junho = dr["Junho"].ToString();
                    Inf.Julho = dr["Julho"].ToString();
                    Inf.Agosto = dr["Agosto"].ToString();
                    Inf.Setembro = dr["Setembro"].ToString();
                    Inf.Outubro = dr["Outubro"].ToString();
                    Inf.Novembro = dr["Novembro"].ToString();
                    Inf.Dezembro = dr["Dezembro"].ToString();
                    Dados.Add(Inf);
                }
            }
            return Dados;
        }
    }
}
