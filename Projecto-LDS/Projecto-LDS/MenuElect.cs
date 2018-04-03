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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int ContagemVazio = int.Parse(textBox4.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int ContagemForaVazio = int.Parse(textBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
