using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas.ConsoleApp.Telas
{
    public class TelaBase
    {
        protected void MontarCabecalho(string configuracaoTituloColunas, params object[] colunas)
        {
            Console.WriteLine();
            Console.WriteLine(configuracaoTituloColunas, colunas);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }
    }
}
