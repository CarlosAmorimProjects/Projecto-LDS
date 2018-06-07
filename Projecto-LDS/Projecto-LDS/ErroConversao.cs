using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS
{
     public class ErroConversaoRecebe: Exception
     {
        

        public ErroConversaoRecebe (string message)
        : base(message)
        {
        }

        public ErroConversaoRecebe (string message, Exception inner)
            : base(message, inner)
        {
        }
     }
}
