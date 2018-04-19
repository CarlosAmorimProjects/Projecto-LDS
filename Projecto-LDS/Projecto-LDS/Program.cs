using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_LDS
{
    static class Program
    {


        static void Main()
        {
            MenuElect menuElect = new MenuElect();
            
            menuElect.ConsumosRecebidos += new CalculoConsumosEventHandler(OnConsumosRecebidos);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());

             void OnConsumosRecebidos (object source, EventArgs e)
            {
                           
            }
            
        }
    }
}
