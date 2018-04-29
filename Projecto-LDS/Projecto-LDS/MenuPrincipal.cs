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
            MenuElect menuElect = new MenuElect();
            Configuracoes config = new Configuracoes();

            menuElect.ConsumosRecebidos += new CalculoConsumosEventHandler(OnConsumosRecebidos);
            menuElect.recebeVazio += new RecebeVazioEventHandler(OnrecebeVazio);
            menuElect.recebeFora += new RecebeForaEventHandler(OnrecebeFora);
            menuElect.recebetarifa += new TarifaEventHandler(Onrecebetarifa);
            config.guardaTarifaSimples += new GuardarTSEventHandler(OnTarifaSimples);
            config.guardaTarifaBiVazio += new GuardarBiVazioEventHandler(OnTarifaBiVazio);
            config.guardaTarifaBiFora += new GuardarBiForaEventHandler(OnTarifaBiFora);
            config.guardaGN += new GuardaGNEventHandler(OnTarifaGN);

            void Onrecebetarifa(object source, string tarifa)
            {
                if (tarifa == "Tarifa Simples")
                {

                }


            }

            void OnrecebeFora(object source, string contagemFora)
            {
                try
                {
                    Int32.TryParse(contagemFora, out int contagemForaInt);
                }
                catch (Exception)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnrecebeVazio(object source, string contagemVazio)
            {
                try
                {
                        Int32.TryParse(contagemVazio, out int contagemVazioInt);
                }
                catch (Exception)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }



            }

            void OnConsumosRecebidos(object source, EventArgs e)
            {
                
            }

            void OnTarifaSimples (object source, string tarifasimples)
            {
                try
                {
                    Int32.TryParse(tarifasimples, out int tarifasimplesInt);
                }
                catch (Exception)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }


            }

            void OnTarifaBiVazio (object source, string tarifaBiVazio)
            {
                try
                {
                    Int32.TryParse(tarifaBiVazio, out int tarifaBiVazioInt);
                }
                catch (Exception)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnTarifaBiFora (object source, string tarifaBiFora)
            {
                try
                {
                    Int32.TryParse(tarifaBiFora, out int tarifaBiForaInt);
                }
                catch (Exception)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnTarifaGN (object source, string tarifaGn)
            {
                 try
                {
                    Int32.TryParse(tarifaGn, out int tarifaGnInt);
                }
                catch (Exception)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

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
            Configuracoes config = new Configuracoes();
            config.ShowDialog();
            ShowDialog();
        }
        
    }

}
