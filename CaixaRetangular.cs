using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosPOO
{
    internal class CaixaRetangular
    {

        public void CalcularVolume()
        {
            
            decimal Comprimento;
            decimal Largura;
            decimal Altura;

            Console.WriteLine("Insira o Comprimento");
            Comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o Largura");
            Largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o Altura");
            Altura = Convert.ToDecimal(Console.ReadLine());

            decimal Volume = Comprimento * Largura * Altura;
            Console.WriteLine("O Volume da Caixa Retangular é " + Volume + "L");
        }
    }
}

