using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Temperatura
    {
       public void ConversorParaCelsius()
        {
            int TemperaturaFahrenheit;
          
            Console.WriteLine("Insira a temperatura em Fahrenheint");
            TemperaturaFahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A Temperatura em Celsius é de " + ((TemperaturaFahrenheit - 32) / 1.8) + "°C");
        }

    }
}
