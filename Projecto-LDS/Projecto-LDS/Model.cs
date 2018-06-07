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

        public void CalculoGN (int LeituraGN, double tarifaGN)
        {
            double resultado = 0;
            resultado = LeituraGN * tarifaGN;

            //RecebeResultadoGN( float resultado);

        }

        
    }
}
