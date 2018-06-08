using Projecto_LDS.Views;
using Projecto_LDS.Model;
using Projecto_LDS.Properties;
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

namespace Projecto_LDS.Model

{
    class Controller
    {
        public Controller()
        {
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

            void OnrecebeGn(object source, string LeituraGN)
            {
                try
                {
                    Int32.Parse(LeituraGN);
                   // Model.Model.CalculoGN(LeituraGN, tarifaGN);

                }
                catch (ArgumentNullException)
                {
                    throw new ErroConversaoRecebe("Campo Vazio");
                }

                catch (FormatException)
                {
                    throw new ErroConversaoRecebe("Valores inválidos");
                }

                catch (OverflowException)
                {
                    throw new ErroConversaoRecebe("Tamanho errado");
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
                    throw new ErroConversaoRecebe("Campo Vazio");
                }

                catch (FormatException)
                {
                    throw new ErroConversaoRecebe("Valores inválidos");
                }

                catch (OverflowException)
                {
                    throw new ErroConversaoRecebe("Tamanho errado");
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
                    throw new ErroConversaoRecebe("Campo Vazio");
                }

                catch (FormatException)
                {
                    throw new ErroConversaoRecebe("Valores inválidos");
                }

                catch (OverflowException)
                {
                    throw new ErroConversaoRecebe("Tamanho errado");
                }
            }

            void OnConsumosRecebidos(object source, EventArgs e)
            {

            }

            void OnTarifaSimples(object source, string tarifasimples)
            {
                try
                {
                    Int32.Parse(tarifasimples);

                }
                catch (ArgumentNullException)
                {
                    throw new ErroConversaoRecebe("Campo Vazio");
                }

                catch (FormatException)
                {
                    throw new ErroConversaoRecebe("Valores inválidos");
                }

                catch (OverflowException)
                {
                    throw new ErroConversaoRecebe("Tamanho errado");
                }


            }

            void OnTarifaBiVazio(object source, string tarifaBiVazio)
            {
                try
                {
                    Int32.Parse(tarifaBiVazio);

                }
                catch (ArgumentNullException)
                {
                    throw new ErroConversaoRecebe("Campo Vazio");
                }

                catch (FormatException)
                {
                    throw new ErroConversaoRecebe("Valores inválidos");
                }

                catch (OverflowException)
                {
                    throw new ErroConversaoRecebe("Tamanho errado");
                }

            }

            void OnTarifaBiFora(object source, string tarifaBiFora)
            {
                try
                {
                    Int32.Parse(tarifaBiFora);

                }
                catch (ArgumentNullException)
                {
                    throw new ErroConversaoRecebe("Campo Vazio");
                }

                catch (FormatException)
                {
                    throw new ErroConversaoRecebe("Valores inválidos");
                }

                catch (OverflowException)
                {
                    throw new ErroConversaoRecebe("Tamanho errado");
                }

            }

            void OnTarifaGN(int LeituraGN, string tarifaGn)
            {
                try
                {
                    Model.CalculoGN(LeituraGN, tarifaGn);

                }
                catch (ErroConversaoRecebe)
                {
                    ExceptionMessage.Message(message);
                }

            }

        }
        /*  Controller control = new Controller();

          public void ConfigsTarifaSimples(string tarifaSimples)
          {
          double tarifaSimplesD = Convert.ToDouble(tarifaSimples);
          }

          public void configsBihoraria (string tarifaBiVazio, string tarifaBiFora)
          {
              double tarifaBiVazioD = Convert.ToDouble(tarifaBiVazio);
              double tarifaBiForaD = Convert.ToDouble(tarifaBiFora);
          }

          public void configsGN (string tarifaGN)
          {
              double tarifaGnD = Convert.ToDouble(tarifaGN);
          }
         */


    }
}
