namespace Projecto_LDS.Views
{
    using System;
    using System.Windows.Forms;

    public delegate void RecebeGNEventHandler(object source, string tarifaGn);
    public delegate void FormCloseEventHandler(object source, EventArgs args);

    public partial class MenuGas : Form
    {
        public event RecebeGNEventHandler RecebeGN;
        public event FormCloseEventHandler FormClose;

        public MenuGas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void OnrecebeGn(MenuGas menuGas, string LeituraGN)
        {
            RecebeGN?.Invoke(this, LeituraGN);

        }

        private void RecebeResultadoGN(float resultado)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LeituraGN = textBox1.Text;
            OnrecebeGn(this, LeituraGN);
        }

        public virtual void OnFormClose()
        {
            FormClose?.Invoke(this, EventArgs.Empty);
        }
    }
}

