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

        private MenuElect menuElect;

        public MenuElect MenuElect
        {
            get
            {
                return menuElect;
            }
            set { menuElect = value; }
        }

        private MenuGas menuGas;

        public MenuGas MenuGas
        {
            get
            {
                return menuGas;
            }
            set { menuGas = value; }
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
            menuElect.ShowDialog();
            if (!this.Visible)
            {
                this.Show();
            }
        }

        private void GN_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuGas.ShowDialog();
            if (!this.Visible)
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracoes config = new Configuracoes();
            config.ShowDialog();
            ShowDialog();
        }

        public void SetCalculaLabel(string text)
        {
            this.lblValorCalculado.Text = text;
        }


        public void HideChilds()
        {
            this.menuElect.DialogResult = DialogResult.Cancel;
            this.menuGas.DialogResult = DialogResult.Cancel;
        }


    }
}



