using Projecto_LDS.Views;
using Projecto_LDS.Model;
using System;
using System.IO;
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

    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Electricidade_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuElect menuElect = new MenuElect();
            menuElect.ShowDialog();
            ShowDialog();

        }

        private void GN_Click(object sender, EventArgs e)
        {

            this.Hide();
            MenuGas menuGas = new MenuGas();
            menuGas.ShowDialog();
            ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracoes config = new Configuracoes();
            config.ShowDialog();
            ShowDialog();
        }

    }
}

