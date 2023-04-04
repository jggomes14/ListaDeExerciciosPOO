using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Calculo
    {
        public void ConversorParaFahrenreint()
        {
            int TemperaturaCelsius;
            Console.WriteLine("Insira a temperatura em Celsius");
            TemperaturaCelsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A Temperatura em Fahrenheint é " + (TemperaturaCelsius * 1.8) + 32 + "F");
        }
    }
}
