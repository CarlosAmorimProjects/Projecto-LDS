using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Projecto de Laboratório de Programção
  Projecto de cálculo de consumos de energia (electricidade e/ou gás natural). 
  Utilizador introduz o consumo no final do mês e o programa dá a energia consumida
  e o valor em euros a pagar tendo em conta a contagem do mês anterior. Traça um gráfico
  dos consumos com as leituras introduzidas. */

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
