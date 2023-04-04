using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Calculo
    {
        public void CalculoDeCombustivel()
        {
            

            int KmInicial;
            int KmFinal;
            int ConsumoDeCombustivel;


            Console.WriteLine("Insira a Quilometragem Inicial do Veiculo");
            KmInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a Quilometragem Final do Veiculo");
            KmFinal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Consumo de Combustivel ao final do percurso");
            ConsumoDeCombustivel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Combustivel consumido por Km percorrido foi de " + (KmFinal - KmInicial) / (ConsumoDeCombustivel));

        }
    }
}
