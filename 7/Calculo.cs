using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Calculo
    {
        public void CalculoDeSalarioComComissao()
        {
            decimal SalarioBase;
            decimal ValorDasVendas;
            decimal Comissao;

            Console.WriteLine("Insira o seu salário base");
            SalarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas do mês");
            ValorDasVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de comissão?");
            Comissao = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O seu salário esse mês será R$ " + ((SalarioBase) + (ValorDasVendas) * (Comissao / 100)));
            Console.ReadKey();
        }
    }
}
