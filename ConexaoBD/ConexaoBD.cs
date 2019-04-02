using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{
   public class _ConexaoBD
    {
        public string Caminho = Properties.Settings.Default.CaminhoBD;
        public MySqlConnection Conexao;
        public MySqlCommand cmd;

        public _ConexaoBD()
        {
            Conexao = new MySqlConnection(Caminho);
            cmd = new MySqlCommand();
            cmd.Connection = Conexao;
        }

        public bool Executar(string sql)
        {
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                Conexao.Open();
                cmd.ExecuteNonQuery();
                Conexao.Close();
                return true;
            }
            catch
            { return false; }
        }

        protected MySqlDataReader Read(string sql)
        {
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                Conexao.Open();
                return cmd.ExecuteReader();
            }
            catch { return null; }           
        }

    }
}
