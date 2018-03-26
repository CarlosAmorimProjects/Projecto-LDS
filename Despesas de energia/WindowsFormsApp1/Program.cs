using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Cálculo de consumos de energia (electricidade e/ou gás natural).
   Utilizador introduz a leitura do contador no final do mês, o programa
   devolve a energia consumida (kWh) e o valor a pagar em euros, com base 
   no cálculo dos consumos desde a contagem anterior. Traça um gráfico dos 
   consumos com as leituras introduzidas.*/

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
