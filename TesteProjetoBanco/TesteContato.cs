using ControleDeTarefas.ConsoleApp.Controlador;
using ControleDeTarefas.ConsoleApp.Domino;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProjetoBanco
{
    [TestClass]
    public class TesteContato
    {
        private ControladorContato controlador;

        public TesteContato()
        {
            controlador = new ControladorContato();
        }

        [TestMethod]
        public void DeveInserirContatos()
        {
            Contato contato = new Contato("Teste Unitario", "teste@gmail.com", "3229-2624", "NDD","Presidente");
            controlador.InserirContato(contato);
            int id = contato.Id;
            Assert.IsTrue(id > 0);
        }
        [TestMethod]
        public void DeveExcluirContatos()
        {
            Contato contato = new Contato("Teste Unitario Excluir Contato", "teste@gmail.com", "3229-2624", "NDD", "Presidente");
            controlador.InserirContato(contato);
            int id = contato.Id;
            controlador.Excluir(id);

            Assert.IsFalse(controlador.ListarContatos().Contains(contato));
        }
        [TestMethod]
        public void DeveListarContatos()
        {
            Contato contato = new Contato("Teste Unitario Vizualizar Contato", "teste@gmail.com", "3229-2624", "NDD", "Presidente");
            controlador.InserirContato(contato);
            Assert.IsFalse(controlador.ListarContatos().Contains(contato));
        }
    }
}
