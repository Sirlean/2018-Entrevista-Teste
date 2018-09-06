using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace teste
{
    public class clsDados
    {
        public SqlConnection Conexao { get; private set; }

        public void OpenConnection()
        {
            Conexao = new SqlConnection();

            Conexao.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoTeste"].ConnectionString;
            Conexao.Open();
        }
        public void CloseConnection()
        {
            Conexao.Close();
        }

    }
}