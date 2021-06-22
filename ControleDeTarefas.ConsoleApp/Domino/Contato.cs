using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Domino
{
    public class Contato
    {
        public Contato() 
        {
            
        }
        //INSERT
        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }
        //VIZUALIZAÇÃO
        public Contato(int id, string nome, string email, string telefone, string empresa, string cargo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { set; get; }

        public string Telefone { set; get; }

        public string Empresa { set; get; }

        public string Cargo { set; get; }
    }
}
