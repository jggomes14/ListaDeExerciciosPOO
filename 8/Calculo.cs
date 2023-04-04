using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Calculo
    {
        public void Volume()
        {
            int raio;
            int altura;
            Console.WriteLine("Insira o raio da lata");
            raio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a altura da lata");
            altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O volume da lata é de " + ((raio * raio) * 3.14) * (altura));
        }
    }
}
