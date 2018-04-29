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

            public delegate void GuardarTSEventHandler(object source, string tarifaSimples);
            public delegate void GuardarBiVazioEventHandler(object source, string tarifaBiVazio);
            public delegate void GuardarBiForaEventHandler(object source, string tarifaBiFora);
            public delegate void GuardaGNEventHandler(object source, string tarifaGN);

        public partial class Configuracoes : Form
        {
            public event GuardarTSEventHandler guardaTarifaSimples;
            public event GuardarBiVazioEventHandler guardaTarifaBiVazio;
            public event GuardarBiForaEventHandler guardaTarifaBiFora;
            public event GuardaGNEventHandler guardaGN;


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
                 string tarifaSimples2 = textBox3.Text;
                 OnTarifaSimples(this, tarifaSimples2);

             }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                string tarifaBiVazio = textBox1.Text;
                OnTarifaBiVazio(this, tarifaBiVazio);
            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                string tarifaBiFora = textBox2.Text;
                OnTarifaBiFora(this, tarifaBiFora);
            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {
                string tarifaGN = textBox4.Text;
                OnTarifaGn(this, tarifaGN);
            }

            private void Configuracoes_Load(object sender, EventArgs e)
            {

            }

            private void OnTarifaSimples(Configuracoes config, string tarifaSimples2)
            {
                guardaTarifaSimples?.Invoke(this, tarifaSimples2);
            }

            private void OnTarifaBiVazio(Configuracoes config, string tarifaBiVazio)
            {
                guardaTarifaBiVazio?.Invoke(this, tarifaBiVazio);

            }

            private void OnTarifaBiFora(Configuracoes config, string tarifaBiFora)
            {
                guardaTarifaBiFora?.Invoke(this, tarifaBiFora);

            }

            private void OnTarifaGn(Configuracoes config, string tarifaGn)
            {
                guardaGN?.Invoke(this, tarifaGn);

            }
        }

}
