﻿using Projecto_LDS.Views;
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
   
    public partial class MenuPrincipal : Form
    {
       // public event CalculoConsumosEventHandler ConsumosRecebidos;

       MenuElect menuElect = new MenuElect();
       menuElect.
        





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

            /*new MenuGas().ShowDialog();
            ShowDialog();
            MenuGas menuGas= new MenuGas();
            this.Hide();
            menuGas.ShowDialog();
            this.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracoes configur = new Configuracoes();
            configur.ShowDialog();
            ShowDialog();
        }
        
        

    }

}