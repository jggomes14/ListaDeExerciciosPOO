using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Calculo
    {
        public int altura;
        public int raio;
        public double VolumeDeUmCilindro()
        {
           

            return  (3.14 * altura) * (raio * raio);
        }
            
    }
}
