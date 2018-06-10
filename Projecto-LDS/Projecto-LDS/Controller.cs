namespace Projecto_LDS.Model
{
    using Projecto_LDS.Views;
    using System;
    using System.Windows.Forms;

    class Controller
    {
        private Configuracoes config = new Configuracoes();
        private MenuPrincipal menuPrincipal = new MenuPrincipal();

        public Controller()
        {
            MenuElect menuElect = new MenuElect();
            menuPrincipal.MenuElect = menuElect;
            MenuGas menuGas = new MenuGas();
            menuPrincipal.MenuGas = menuGas;

            menuElect.FormClose += new Projecto_LDS.FormCloseEventHandler(OnFormClose);
            menuElect.ConsumosRecebidos += new CalculoConsumosEventHandler(OnConsumosRecebidos);
            menuElect.recebeVazio += new RecebeVazioEventHandler(OnrecebeVazio);
            menuElect.recebeFora += new RecebeForaEventHandler(OnrecebeFora);
            menuElect.recebetarifa += new TarifaEventHandler(Onrecebetarifa);
            menuGas.RecebeGN += new RecebeGNEventHandler(OnrecebeGn);
            menuGas.FormClose += new FormCloseEventHandler(OnFormClose);

            config.guardaTarifaSimples += new GuardarTSEventHandler(OnTarifaSimples);
            config.guardaTarifaBiVazio += new GuardarBiVazioEventHandler(OnTarifaBiVazio);
            config.guardaTarifaBiFora += new GuardarBiForaEventHandler(OnTarifaBiFora);
            config.guardaGN += new GuardaGNEventHandler(OnTarifaGN);

            Application.Run(menuPrincipal);


        }
        void Onrecebetarifa(object source, string tarifa)
        {
            if (tarifa == "Tarifa Simples")
            {
                try
                {
                    Model.CalculoElecSimples(ContagemVazio, ContagemFora);
                }

                catch (ErroConversaoRecebe)
                {
                    ExceptionMessage.Message(message);
                }
            }

            else if (tarifa == "Tarifa Bi-Horária")
            {
                try
                {
                    Model.CalculoElecBi(ContagemVazio, ContagemFora);
                }

                catch (ErroConversaoRecebe)
                {
                    ExceptionMessage.Message(message);
                }
            }

            else if (tarifa == "Tarifa Tri-Horária")
            {
                try
                {
                    Model.CalculoElecTri(ContagemVazio, ContagemFora);
                }

                catch (ErroConversaoRecebe)
                {
                    ExceptionMessage.Message(message);
                }
            }
        }

        void OnrecebeGn(object source, string LeituraGN)
        {
            try
            {
                Model.CalculoGN(LeituraGN);
            }
            catch (ErroConversaoRecebe)
            {
                ExceptionMessage.Message(message);
            }
        
                int leituraGN = Int32.Parse(LeituraGN);
                menuPrincipal.SetCalculaLabel("Valor Calculado:" + leituraGN);
                menuPrincipal.HideChilds();
                menuPrincipal.Show();

        }

        void OnrecebeFora(object source, string contagemFora)
        {

        }

        void OnrecebeVazio(object source, string contagemVazio)
        {

        }

        void OnConsumosRecebidos(object source, EventArgs e)
        {

        }

        void OnTarifaSimples(object source, string tarifasimples)
        {


        }

        void OnTarifaBiVazio(object source, string tarifaBiVazio)
        {
           

        }

        void OnTarifaBiFora(object source, string tarifaBiFora)
        {

        }

        void OnTarifaGN(object source, string tarifaGn)
        {
              
        }

        void OnFormClose(object source, EventArgs e)
        {
            menuPrincipal.HideChilds();
            menuPrincipal.Show();
        }

    }
}
