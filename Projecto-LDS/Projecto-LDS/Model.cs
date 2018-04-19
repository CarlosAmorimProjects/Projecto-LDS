using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS.Model
{
    
    class Model
    {

        public double CalculoConsumos(int leituraVazio, int leituraFora, double tarifaVazio, double tarifaFora)

        {

            double resultado;

            resultado = (leituraVazio * tarifaVazio) + (leituraFora * tarifaFora);
            return resultado;

        }

        
    }
}
