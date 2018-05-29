using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS
{
    class ErroConversao
    {
        public static void ErroConversaoRecebe ()
        {
            ExceptionMessage.Message("Apenas números inteiros");
            return;

        }

        public static void ErroConversaoVazio()
        {
            ExceptionMessage.Message("Não foram introduzidos dados");
            return;

        }
    }
}
