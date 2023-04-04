using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Calculo
    {
        public void VolumeDeUmCilindro()
        {
            Console.ReadKey();
            int altura;
            int raio;

            Console.WriteLine("Insira a altura do cilindro");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o raio do cilindro");
            raio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Volume é igual a " + (3.14 * altura) * (raio * raio));
        }
            
    }
}
