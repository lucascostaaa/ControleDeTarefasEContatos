using ControleDeTarefas.ConsoleApp.Conexao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ControleDeTarefas.ConsoleApp.Controlador
{
    public class ControladorTarefa : Conexao.Conexao
    {
        private readonly SqlTarefa sqlTarefa;

        public ControladorTarefa() 
        {
            sqlTarefa = new SqlTarefa();
        }
        public void InserirTarefa(Tarefa tarefa)
        {
            SqlCommand comandoInserir = new SqlCommand();
            comandoInserir.Connection = CriarConexao();

            comandoInserir.CommandText = sqlTarefa.Insercao();

            comandoInserir.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoInserir.Parameters.AddWithValue("DATACRIACAO", tarefa.Datacriacao);
            comandoInserir.Parameters.AddWithValue("DATACONCLUSAO", tarefa.DataConclusao);
            comandoInserir.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);
            comandoInserir.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);

            object id = comandoInserir.ExecuteScalar();

            tarefa.Id = Convert.ToInt32(id);

            FecharConexao();
        }
        public List<Tarefa> ListarTarefasPendentes()
        {
            SqlCommand comandoVizualisar = new SqlCommand();
            comandoVizualisar.Connection = CriarConexao();

            string RecebeVisualizacao = sqlTarefa.VisualizarTarefasPendentes();

            comandoVizualisar.CommandText = RecebeVisualizacao;

            SqlDataReader lerconsultas = comandoVizualisar.ExecuteReader();

            List<Tarefa> tarefas = new List<Tarefa>();

            while (lerconsultas.Read())
            {
                int id = Convert.ToInt32(lerconsultas["Id"]);
                string titulo = Convert.ToString(lerconsultas["Titulo"]);
                DateTime dataCriacao = Convert.ToDateTime(lerconsultas["dataCriacao"]);
                DateTime dataConclusao = Convert.ToDateTime(lerconsultas["DataConclusao"]);
                int percentual = Convert.ToInt32(lerconsultas["Percentual"]);
                string prioridade = Convert.ToString(lerconsultas["Prioridade"]);

                Tarefa tarefa = new Tarefa(id, titulo, dataCriacao, dataConclusao, percentual, prioridade);
                tarefas.Add(tarefa);

            }

            FecharConexao();

            return tarefas;
        }
        public List<Tarefa> ListarTarefasConcluidas()
        {
            SqlCommand comandoVizulisar = new SqlCommand();
            comandoVizulisar.Connection = CriarConexao();

            string RecebeVisualizacao = sqlTarefa.VisualizarTarefasConcluidas();

            comandoVizulisar.CommandText = RecebeVisualizacao;

            SqlDataReader lerconsultas = comandoVizulisar.ExecuteReader();

            List<Tarefa> tarefas = new List<Tarefa>();

            while (lerconsultas.Read())
            {
                int id = Convert.ToInt32(lerconsultas["Id"]);
                string titulo = Convert.ToString(lerconsultas["Titulo"]);
                DateTime dataCriacao = Convert.ToDateTime(lerconsultas["dataCriacao"]);
                DateTime dataConclusao = Convert.ToDateTime(lerconsultas["DataConclusao"]);
                int percentual = Convert.ToInt32(lerconsultas["Percentual"]);
                string prioridade = Convert.ToString(lerconsultas["Prioridade"]);

                Tarefa tarefa = new Tarefa(id, titulo, dataCriacao, dataConclusao, percentual, prioridade);
                tarefas.Add(tarefa);

            }
            FecharConexao();

            return tarefas;
        }

        public List<Tarefa> ListarTodasTarefas()
        {
            SqlCommand comandoVizulisar = new SqlCommand();
            comandoVizulisar.Connection = CriarConexao();

            string RecebeVisualizacao = sqlTarefa.VisualizarTodasTarefas();

            comandoVizulisar.CommandText = RecebeVisualizacao;

            SqlDataReader lerconsultas = comandoVizulisar.ExecuteReader();

            List<Tarefa> tarefas = new List<Tarefa>();

            while (lerconsultas.Read())
            {
                int id = Convert.ToInt32(lerconsultas["Id"]);
                string titulo = Convert.ToString(lerconsultas["Titulo"]);
                DateTime dataCriacao = Convert.ToDateTime(lerconsultas["dataCriacao"]);
                DateTime dataConclusao = Convert.ToDateTime(lerconsultas["DataConclusao"]);
                int percentual = Convert.ToInt32(lerconsultas["Percentual"]);
                string prioridade = Convert.ToString(lerconsultas["Prioridade"]);

                Tarefa tarefa = new Tarefa(id, titulo, dataCriacao, dataConclusao, percentual, prioridade);
                tarefas.Add(tarefa);

            }
            FecharConexao();

            return tarefas;
        }

        public void EditarTarefa(int id, Tarefa tarefa)

        {
            SqlCommand comandoEdicao = new SqlCommand();
            comandoEdicao.Connection = CriarConexao();

            comandoEdicao.CommandText = sqlTarefa.AtualizarTarefa();

            comandoEdicao.Parameters.AddWithValue("ID",id);
            comandoEdicao.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoEdicao.Parameters.AddWithValue("DATACONCLUSAO", tarefa.DataConclusao);
            comandoEdicao.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);
            comandoEdicao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);

            comandoEdicao.ExecuteNonQuery();

            FecharConexao();

        }
        public void Excluir(int id)
        {
            SqlCommand comandoExcluir = new SqlCommand();
            comandoExcluir.Connection = CriarConexao();

            comandoExcluir.CommandText = sqlTarefa.DeletarTarefa();

            comandoExcluir.Parameters.AddWithValue("ID",id);

            comandoExcluir.ExecuteNonQuery();

            FecharConexao();
        }
    }
}
