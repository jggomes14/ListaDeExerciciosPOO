using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Calculo
    {
        public void Esfera()
        {
            int raio;
            Console.WriteLine("Insira o valor do Raio da Esfera");
            raio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O volume da esfera é de " + (4 * 3.14) * (raio * raio * raio) / 3);
        }
    }
}
