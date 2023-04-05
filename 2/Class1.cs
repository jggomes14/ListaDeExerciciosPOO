using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Temperatura
    {
        public int TemperaturaFahrenheit;
        public double ConversorParaCelsius()
        {
           return ((TemperaturaFahrenheit - 32) / 1.8);
        }

    }
}
