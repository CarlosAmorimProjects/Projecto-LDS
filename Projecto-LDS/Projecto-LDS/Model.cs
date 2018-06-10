using Projecto_LDS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS.Model
{
    
    class Model
    {
      
        public static double CalculoConsumos(int leituraVazio, int leituraFora, double tarifaVazio, double tarifaFora)

        {

            double resultado;

            resultado = (leituraVazio * tarifaVazio) + (leituraFora * tarifaFora);
            return resultado;

        }

        public static void CalculoGN (string LeituraGN)
        {
            //double resultado = 0;
            double tarifaGNCalculo;

            try
            {
                tarifaGNCalculo = Double.Parse(LeituraGN);
            }

            catch (ErroConversaoRecebe)
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
            
            // resultado = LeituraGN*TarifaGN;

        }

        public static void CalculoElecSimples (string ContagemVazio, string ContagemFora)
        {
            double ConsumoElecSimplesVazio;
            double ConsumoElecSimplesFora;
            double resultado;

            try
            {
                ConsumoElecSimplesFora = Double.Parse(ContagemVazio);
                ConsumoElecSimplesVazio = Double.Parse(ContagemFora);

            }

            catch (ErroConversaoRecebe)
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

            // resultado = (ContagemVazio+ContagemFora)*tarifaSimples;

        }

        public static void CalculoElecBi(string ContagemVazio, string ContagemFora)
        {
            double ConsumoElecVazio;
            double ConsumoElecFora;
            double resultado;

            try
            {
                ConsumoElecVazio = Double.Parse(ContagemVazio);
                ConsumoElecFora = Double.Parse(ContagemFora);

            }

            catch (ErroConversaoRecebe)
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

            // resultado = (ContagemVazio*tarifaBiVazio) + (ContagemFora*tarifaBiFora);

        }

        public static void CalculoElecTri(string ContagemVazio, string ContagemFora)
        {
            double ConsumoElecVazio;
            double ConsumoElecFora;
            double resultado;

            try
            {
                ConsumoElecVazio = Double.Parse(ContagemVazio);
                ConsumoElecFora = Double.Parse(ContagemFora);

            }

            catch (ErroConversaoRecebe)
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

            // resultado = (ContagemVazio*tarifaBiVazio) + (ContagemFora*tarifaBiFora);

        }


    }

        
    }
}
