using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_LDS.Views
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string tarifaSimples = textBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tarifaBiVazio = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string tarifaBiFora = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string tarifaGN = textBox4.Text;
        }
    }
}
