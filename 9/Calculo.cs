using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Calculo
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double Harmonica()
        {
            return 3 / (1 / nota1) + (1 / nota2) + (1 / nota3);   
        }
    }
}
