using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp
{
        public class Tarefa
        {
            public Tarefa()
            {

            }
        //INSERT 
            public Tarefa(string titulo, DateTime datacriacao, DateTime dataConclusao, int percentual, string prioridade)
            {
                Titulo = titulo;
                Datacriacao = datacriacao;
                DataConclusao = dataConclusao;
                Percentual = percentual;
                Prioridade = prioridade;
            }
        //VISUALIZAR
            public Tarefa(int id, string titulo, DateTime datacriacao, DateTime dataConclusao, int percentual, string prioridade)
            {
                Id = id;
                Titulo = titulo;
                Datacriacao = datacriacao;
                DataConclusao = dataConclusao;
                Percentual = percentual;
                Prioridade = prioridade;
            }
        //EDITE
            public Tarefa(string titulo, DateTime dataConclusao, int percentual, string prioridade)
            {
                Titulo = titulo;
                DataConclusao = dataConclusao;
                Percentual = percentual;
                Prioridade = prioridade;
            }

            public int Id { get; set; }

                public string Titulo { get; set; }

                public DateTime Datacriacao { get; set; }

                public DateTime DataConclusao { get; set; }

                public int Percentual { get; set; }

                public string Prioridade { get; set; }
            }
}

