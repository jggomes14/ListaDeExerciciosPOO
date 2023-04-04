using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Calculo
    {
        public void Ponderada()
        {
            double prova1;
            double prova2;
            double peso1;
            double peso2;
            Console.WriteLine("Insira a nota da prova 1");
            prova1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a nota da prova 2");
            prova2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso da prova 1");
            peso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso da prova 2");
            peso2 = Convert.ToDouble(Console.ReadLine());

            double NotaPonderada = ((prova1 * peso1) + (prova2 + peso2)) / (peso1 + peso2);

            Console.WriteLine("A média ponderada do aluno em questão é " + NotaPonderada);
        }
    }
}
