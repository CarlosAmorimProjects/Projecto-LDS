using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS.Model
{
    class Calcular
    {

        public double CalculoConsumos (int LeituraVazio, int LeituraForaVazio)
        {
            double resultado;

            resultado = (LeituraVazio * 0.19) + (LeituraForaVazio * 0.9);

            return resultado;

        }

    }
}
