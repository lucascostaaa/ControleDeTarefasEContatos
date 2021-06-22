using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Conexao
{
    public class SqlContato
    {
        public string Insercao()
        {
            string sqlInsercao =

           @"INSERT INTO TB_CONTATOS
            (
	            [NOME],
	            [EMAIL],
	            [TELEFONE],
                [EMPRESA],
                [CARGO]
            )
            VALUES
            (
	            @NOME,
	            @EMAIL,
	            @TELEFONE,
                @EMPRESA,
                @CARGO
            )";

            sqlInsercao +=
                @"SELECT SCOPE_IDENTITY();";

            return sqlInsercao;
        }
        public string Visualizar()
        {
            string sqlVisualizar =
                @"SELECT
                [ID],
                [NOME],
                [EMAIL],
                [TELEFONE],
                [EMPRESA],
                [CARGO] 
            FROM TB_Contatos";

            return sqlVisualizar;
        }

        //public string VizualizarDesenvolvedor()
        //{
        //    string sqlVisualizar = @"SELECT"
        //}
        public string AtualizarContato()
        {
            string sqlAtualiza = @"UPDATE TB_Contatos

            SET
            [NOME] = @NOME, 
		    [EMAIL] = @EMAIL,
		    [TELEFONE] = @TELEFONE,
		    [EMPRESA] = @EMPRESA,
            [CARGO] = @CARGO

            WHERE
                [ID] = @ID";

            return sqlAtualiza;
        }
        public string DeletarContato()
        {
            string sqlDelete = @"DELETE FROM TB_Contatos
             WHERE
             [ID] = @ID";

            return sqlDelete;
        }
    }
}
