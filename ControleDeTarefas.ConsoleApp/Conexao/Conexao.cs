using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Conexao
{
    public class Conexao
    {
        private SqlConnection conexaoComBanco;

        private string enderecoTarefaDB =
             @"Data Source = (localDb)\MSSqlLocalDB; Initial Catalog = GerenciadorTarefasDB; Integrated Security = True; Pooling = False";
        public SqlConnection CriarConexao()
        {
            conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoTarefaDB;
            conexaoComBanco.Open();

            return conexaoComBanco;
        }
        public void FecharConexao()
        {
            conexaoComBanco.Close();
        }
    }
}
