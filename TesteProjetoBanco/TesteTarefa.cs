using ControleDeTarefas.ConsoleApp;
using ControleDeTarefas.ConsoleApp.Controlador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TesteProjetoBanco
{
    [TestClass]
    public class TesteTarefa
    {
        private ControladorTarefa controlador;

        public TesteTarefa()
        {
            controlador = new ControladorTarefa();
        }
        [TestMethod]
        public void DeveInserirTarefa()
        {
            DateTime datacriacao = DateTime.Now;
            DateTime dataConclusao = new DateTime(2021,06,22);
            Tarefa tarefa = new Tarefa("test", datacriacao, dataConclusao, 80, "normal");
            controlador.InserirTarefa(tarefa);
            int id = tarefa.Id;
            Assert.IsTrue(id > 0);
        }
        [TestMethod]
        public void DeveExcluirTarefa()
        {
            DateTime datacriacao = DateTime.Now;
            DateTime dataConclusao = new DateTime(2021, 07, 05);
            Tarefa tarefa = new Tarefa("Teste Unitario Excluir", datacriacao, dataConclusao, 10, "Baixa");

            controlador.InserirTarefa(tarefa);
            int id = tarefa.Id;
            controlador.Excluir(id);

            Assert.IsFalse(controlador.ListarTodasTarefas().Contains(tarefa));
        }

        [TestMethod]
        public void DeveRetornarTodasAsTarefas()
        {
            DateTime datacriacao = DateTime.Now;
            DateTime dataConclusao = new DateTime(2021, 07, 05);
            Tarefa tarefa = new Tarefa("Teste Unitario Vizualizar", datacriacao, dataConclusao, 50, "Media");

            controlador.InserirTarefa(tarefa);

            Assert.IsFalse(controlador.ListarTodasTarefas().Contains(tarefa));
        }
    }
}


 