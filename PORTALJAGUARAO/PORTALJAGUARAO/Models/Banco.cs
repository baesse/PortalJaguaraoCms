using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public static class Banco
    {

        public static SqlConnection GetConexao()
        {
            SqlConnection Conexao = new SqlConnection("Server=192.168.0.86; Database=bdportal;User Id=sa;Password =12345qaz@; ");
            Conexao.Open();
            return Conexao;


        }

        public static SqlCommand GetComando(SqlConnection Conexao)
        {
            SqlCommand Comando = Conexao.CreateCommand();
            return Comando;

        }

        public static SqlDataReader Getreader(SqlCommand Comando)
        {
            SqlDataReader Reader = Comando.ExecuteReader();
            return Reader;

        }
    }
}