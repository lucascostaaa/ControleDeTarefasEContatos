using ControleDeTarefas.ConsoleApp.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Telas
{
    public class TelaTarefa : TelaBase
    {
        private readonly ControladorTarefa controladorTarefa;
        public TelaTarefa(ControladorTarefa controlador)
        {
            controladorTarefa = controlador;
        }

        public void InserirTarefa() 
        {
            controladorTarefa.InserirTarefa(ObterTarefa());

            Console.WriteLine("inserido com sucesso!");
            Console.ReadLine();
        }

        public void Listar() 
        {
            string opcao;

            Console.WriteLine("Escolha uma Opção");
            Console.WriteLine("1 - Tarefas Finalizado");
            Console.WriteLine("2 - Tarefas Pendente");
            Console.WriteLine("3 - Ver todas as Tarefas");
            opcao = Console.ReadLine();

            if(opcao == "1")
            {
                ListarTarefasConcluidas();
            }
            if(opcao == "2")
            {
                ListarTarefasPendentes();
            }
            if(opcao == "3")
            {
                ListarTodasTarefas();
            }
        }
        private void ListarTarefasPendentes() 
        {
            string configuracaoColunasTabela = "{0,-5}|{1,-30}|{2,-25}|{3,-25}|{4,-10}|{5,-10}";

            MontarCabecalho(configuracaoColunasTabela, "id", "titulo", "dataCriacao", "dataConclusao", "percentual", "prioridade");

            List<Tarefa> tarefas = controladorTarefa.ListarTarefasPendentes();
            foreach(Tarefa tarefa in tarefas) 
            {
                Console.WriteLine(configuracaoColunasTabela, tarefa.Id, tarefa.Titulo, tarefa.Datacriacao, tarefa.DataConclusao, tarefa.Percentual, tarefa.Prioridade);
            }

            Console.ReadLine();
        } 

        private void ListarTarefasConcluidas()
        {
            string configuracaoColunasTabela = "{0,-5}|{1,-30}|{2,-25}|{3,-25}|{4,-10}|{5,-10}";

            MontarCabecalho(configuracaoColunasTabela, "id", "titulo", "dataCriacao", "dataConclusao", "percentual", "prioridade");

            List<Tarefa> tarefas = controladorTarefa.ListarTarefasConcluidas();
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(configuracaoColunasTabela, tarefa.Id, tarefa.Titulo, tarefa.Datacriacao, tarefa.DataConclusao, tarefa.Percentual, tarefa.Prioridade);
            }

            Console.ReadLine();

        } 
        private void ListarTodasTarefas()
        {
            string configuracaoColunasTabela = "{0,-5}|{1,-30}|{2,-25}|{3,-25}|{4,-10}|{5,-10}";

            MontarCabecalho(configuracaoColunasTabela, "id", "titulo", "dataCriacao", "dataConclusao", "percentual", "prioridade");

            List<Tarefa> tarefas = controladorTarefa.ListarTodasTarefas();
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(configuracaoColunasTabela, tarefa.Id, tarefa.Titulo, tarefa.Datacriacao, tarefa.DataConclusao, tarefa.Percentual, tarefa.Prioridade);
            }

            Console.ReadLine();
        }

        public void EditarTarefa()
        {
            ListarTodasTarefas();

            Console.WriteLine("Informe o id da tarefa que pretende Editar");
            int id = Convert.ToInt32(Console.ReadLine());

            controladorTarefa.EditarTarefa(id, ObterEditarTarefa());

            Console.WriteLine("Editado com sucesso!");
            Console.ReadLine();
        }
        public void ExluirTarefa()
        {
            ListarTodasTarefas();

            Console.WriteLine("Informe o id da tarefa que deseja Excluir");
            int id = Convert.ToInt32(Console.ReadLine());

            controladorTarefa.Excluir(id);

            Console.WriteLine("Exluido com sucesso");
            Console.ReadLine();
       
        }
        private Tarefa ObterTarefa()
        {
            Console.Write("Digite o titulo da tarefa: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a data de Criação: ");
            DateTime dataCriacao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a data dr Conclusão: ");
            DateTime dataConclusao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o percentual: ");
            int percentual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a prioridade sendo (Baixa/Normal/Alta): ");
            string prioridade = Console.ReadLine();

            return new Tarefa(titulo, dataCriacao, dataConclusao, percentual, prioridade);
        }

        private Tarefa ObterEditarTarefa()
        {
            Console.Write("Digite o titulo da tarefa: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a data dr Conclusão: ");
            DateTime dataConclusao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o percentual: ");
            int percentual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a prioridade sendo (Baixa/Normal/Alta): ");
            string prioridade = Console.ReadLine();

            return new Tarefa(titulo, dataConclusao, percentual, prioridade);
        }

    }
}
