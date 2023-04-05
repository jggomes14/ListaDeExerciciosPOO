using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Calculo
    {
        public int KmInicial;
        public int KmFinal;
        public int ConsumoDeCombustivel;
        public double CalculoDeCombustivel()
        {
         

            return (KmFinal - KmInicial) / (ConsumoDeCombustivel);

        }
    }
}
