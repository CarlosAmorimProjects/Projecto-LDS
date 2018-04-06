using Projecto_LDS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_LDS
{
    public partial class MenuElect : Form
    {
        public MenuElect()
        {
            InitializeComponent();
        }

        private void escolhaTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
            int ContagemVazio = int.Parse(LeituraVazio.Text);
            

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
            int ContagemForaVazio = int.Parse(LeituraForaVazio.Text);
        }

        /*private void Calcular(int LeituraVazio, int LeituraForaVazio)
        {
            Calcular::CalculoConsumos(int LeituraVazio, int LeituraForaVazio);
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
