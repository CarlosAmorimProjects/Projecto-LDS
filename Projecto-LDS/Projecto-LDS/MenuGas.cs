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
    public delegate void RecebeGNEventHandler(object source, string tarifaGn);


    public partial class MenuGas : Form
    {
        public event RecebeGNEventHandler RecebeGN;

        public MenuGas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string LeituraGN = textBox1.Text;
            OnrecebeGn(this, LeituraGN);
        }

        public virtual void OnrecebeGn(MenuGas menuGas, string LeituraGN)
        {
            RecebeGN?.Invoke(this, LeituraGN);

        }

        private void RecebeResultadoGN (float resultado)
        {
            //textBox2_TextChanged(this, resultado);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
