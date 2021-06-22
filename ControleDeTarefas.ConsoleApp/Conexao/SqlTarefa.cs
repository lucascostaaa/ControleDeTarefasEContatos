using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Conexao
{
    public class SqlTarefa
    {
        public string Insercao()
        {
            string sqlInsercao =

            @"INSERT INTO TB_Tarefas 
	                (
		                [TITULO], 
		                [DATACRIACAO], 
		                [DATACONCLUSAO],
                        [PERCENTUAL],
                        [PRIORIDADE]
	                ) 
	                VALUES
	                (
                        @TITULO, 
		                @DATACRIACAO, 
		                @DATACONCLUSAO,
                        @PERCENTUAL,
                        @PRIORIDADE
	                );";

            sqlInsercao +=
                @"SELECT SCOPE_IDENTITY();";

            return sqlInsercao;
        }
        public string VisualizarTarefasPendentes()
        {
            string sqlVisualizar=
            @"SELECT
                [ID],
                [TITULO],
                [DATACRIACAO],
                [DATACONCLUSAO],
                [PERCENTUAL],
                [PRIORIDADE] 
            FROM TB_Tarefas 
            WHERE
                [PERCENTUAL] < 100";

            return sqlVisualizar;
        }
        public string VisualizarTarefasConcluidas()
        {
            string sqlVizualizar= 
            @"SELECT
                 [ID],
                 [TITULO],
                 [DATACRIACAO],
                 [DATACONCLUSAO],
                 [PERCENTUAL],
                 [PRIORIDADE] 
            FROM TB_Tarefas 
            WHERE
                 [PERCENTUAL] = 100";

            return sqlVizualizar;
        }
        public string VisualizarTodasTarefas()
        {
            string sqlVizualizar =
            @"SELECT
                 [ID],
                 [TITULO],
                 [DATACRIACAO],
                 [DATACONCLUSAO],
                 [PERCENTUAL],
                 [PRIORIDADE] 
            FROM TB_Tarefas";

            return sqlVizualizar;
        }
        public string AtualizarTarefa()
        {
            string sqlAtualiza = @"UPDATE TB_Tarefas

            SET
            [TITULO] = @TITULO, 
		    [DATACONCLUSAO] = @DATACONCLUSAO,
		    [PERCENTUAL] = @PERCENTUAL,
		    [PRIORIDADE] = @PRIORIDADE

            WHERE
                [ID] = @ID";

            return sqlAtualiza;
        }
        public string DeletarTarefa()
        {
            string sqlDelete = @"DELETE FROM TB_Tarefas
             WHERE
             [ID] = @ID";

            return sqlDelete;
        }
    }
}
