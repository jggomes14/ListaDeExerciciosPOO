using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Calculo
    {
        public double raio;
        public double altura;
        public double Volume()
        {
          return (raio * raio * 3.14) * altura;
        }
    }
}
