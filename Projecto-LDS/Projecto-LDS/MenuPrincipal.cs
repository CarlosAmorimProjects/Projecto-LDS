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
            MenuGas menuGas = new MenuGas();

            menuElect.ConsumosRecebidos += new CalculoConsumosEventHandler(OnConsumosRecebidos);
            menuElect.recebeVazio += new RecebeVazioEventHandler(OnrecebeVazio);
            menuElect.recebeFora += new RecebeForaEventHandler(OnrecebeFora);
            menuElect.recebetarifa += new TarifaEventHandler(Onrecebetarifa);
            menuGas.RecebeGN += new RecebeGNEventHandler(OnrecebeGn);
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

            void OnrecebeGn (object source, string LeituraGN)
            {
                try
                {
                    Int32.Parse(LeituraGN);

                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                    return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnrecebeFora(object source, string contagemFora)
            {
                try
                {
                    Int32.Parse(contagemFora);

                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                    return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnrecebeVazio(object source, string contagemVazio)
            {
                try
                {
                    Int32.Parse(contagemVazio);

                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                    return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
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
                    Int32.Parse(tarifasimples);
                    
                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                  return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                
            }

            void OnTarifaBiVazio (object source, string tarifaBiVazio)
            {
                try
                {
                    Int32.Parse(tarifaBiVazio);

                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                    return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnTarifaBiFora (object source, string tarifaBiFora)
            {
                try
                {
                    Int32.Parse(tarifaBiFora);

                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                    return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

            }

            void OnTarifaGN (object source, string tarifaGn)
            {
                try
                {
                    Int32.Parse(tarifaGn);

                }
                catch (ArgumentNullException)
                {
                    ExceptionMessage.Message("Não foram introduzidos dados");
                    return;
                }

                catch (FormatException)
                {
                    ExceptionMessage.Message("Apenas números inteiros permitidos");
                    return;
                }

                catch (OverflowException)
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
