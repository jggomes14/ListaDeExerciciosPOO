using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Calculo
    {
        public int TemperaturaCelsius;
        public double ConversorParaFahrenreint()
        {


           return (TemperaturaCelsius * 1.8) + 32;
        }
    }
}
