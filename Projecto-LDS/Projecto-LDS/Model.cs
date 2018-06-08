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

        public static void CalculoGN (int LeituraGN, string  tarifaGN)
        {
            double resultado = 0;
            double tarifaGNCalculo;

            try
            {
                tarifaGNCalculo = Double.Parse(tarifaGN);
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

            
            resultado = tarifaGNCalculo * LeituraGN;



        }

        
    }
}
