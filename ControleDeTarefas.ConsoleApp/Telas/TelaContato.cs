using ControleDeTarefas.ConsoleApp.Controlador;
using ControleDeTarefas.ConsoleApp.Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Telas
{
    public class TelaContato : TelaBase
    {
        private readonly ControladorContato controladorContato;

        public TelaContato(ControladorContato controlador)
        {
            controladorContato = controlador;
        }
        public void InserirContato()
        {
            controladorContato.InserirContato(ObterContato());

            Console.WriteLine("inserido com sucesso!");
            Console.ReadLine();
        }
        public void ListarContatos()
        {
            string configuracaoColunasTabela = "{0,-5}|{1,-30}|{2,-25}|{3,-25}|{4,-10}|{5,-10}";

            MontarCabecalho(configuracaoColunasTabela, "id", "nome", "email", "telefone", "empresa", "cargo");

            List<Contato> contatos = controladorContato.ListarContatos();
            foreach (Contato contato in contatos)
            {
                Console.WriteLine(configuracaoColunasTabela, contato.Id, contato.Nome, contato.Email, contato.Telefone, contato.Empresa, contato.Cargo);
            }

            Console.ReadLine();
        }

        public void EditarContato() 
        {
            ListarContatos();

            Console.WriteLine("Informe o id do contato que pretende Editar");
            int id = Convert.ToInt32(Console.ReadLine());

            controladorContato.EditarContato(id, ObterContato());

            Console.WriteLine("Editado com sucesso!");
            Console.ReadLine();
        }

        public void ExluirContato()
        {
            ListarContatos();

            Console.WriteLine("Informe o id da Contato que deseja Excluir");
            int id = Convert.ToInt32(Console.ReadLine());

            controladorContato.Excluir(id);

            Console.WriteLine("Exluido com sucesso");
            Console.ReadLine();

        }
        private Contato ObterContato()
        {
            Console.Write("Digite o Nome do Contato: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o E-mail do Contato: ");
            string email = Console.ReadLine();

            Console.Write("Digite o Numero do Contato: ");
            string numero = Console.ReadLine();

            Console.Write("Digite o nome da Empresa: ");
            string empresa = Console.ReadLine();

            Console.Write("Digite o cargo do contato: ");
            string cargo = Console.ReadLine();

            return new Contato(nome, email, numero, empresa, cargo);
        }
    }
}
