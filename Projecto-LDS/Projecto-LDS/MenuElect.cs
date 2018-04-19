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
    // criar o delegate
    public delegate void CalculoConsumosEventHandler(object source, EventArgs args);

    public partial class MenuElect : Form

    {
        
        public event CalculoConsumosEventHandler ConsumosRecebidos;
                
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            String tarifa = comboBox1.Text;
            
            OnConsumosRecebidos();


            

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
            //label2.Text = RecebeResultado (double resultado);

        }

        public double RecebeResultado (double resultado)
        {
            return resultado;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        // método que recebe notificação do click
        protected virtual void OnConsumosRecebidos()
        {
            ConsumosRecebidos?.Invoke(this, EventArgs.Empty);
        }
    }
}
