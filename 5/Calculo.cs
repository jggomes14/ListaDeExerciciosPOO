using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Calculo
    {
        public int raio;
        public double Esfera()
        {
           return (4 * 3.14) * (raio * raio * raio) / 3;
        }
    }
}
