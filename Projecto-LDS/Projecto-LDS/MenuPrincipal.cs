using Projecto_LDS.Views;
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
                
        public MenuPrincipal()
        {
            InitializeComponent();
            MenuElect menuElect = new MenuElect();
            menuElect.ConsumosRecebidos += new CalculoConsumosEventHandler(OnConsumosRecebidos);
            menuElect.recebeVazio += new RecebeVazioEventHandler(OnrecebeVazio);
            menuElect.recebeFora += new RecebeForaEventHandler(OnrecebeFora);
            menuElect.recebetarifa += new TarifaEventHandler(Onrecebetarifa);

            void Onrecebetarifa (object source, string tarifa)
            {
              
            }

            void OnrecebeFora (object source, int contagemFora)
            {

            }
           
            void OnrecebeVazio (object source, int contagemVazio)
            {
               
            }

            void OnConsumosRecebidos(object source, EventArgs e)
            {
                
            }

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
            Configuracoes configur = new Configuracoes();
            configur.ShowDialog();
            ShowDialog();
        }
        
    }

}
