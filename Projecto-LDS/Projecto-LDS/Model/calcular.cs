using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS.Model
{
    class Calcular
    {

        public double Calculo(int leituraVazio, int leituraFora, double tarifaVazio, double tarifaFora)

        {
            double resultado;

            resultado = (leituraVazio * tarifaVazio) + (leituraFora * tarifaFora);

            return resultado;

        }
        

    }
}
