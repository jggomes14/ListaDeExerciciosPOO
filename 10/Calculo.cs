using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Calculo
    {
        public double prova1;
        public double prova2;
        public double peso1;
        public double peso2;
        public double Ponderada()
        {
           return (prova1 * peso1) + (prova2 + peso2) / (peso1 + peso2);  
        }
    }
}
