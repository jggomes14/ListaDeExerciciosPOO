using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Calculo
    {
        public decimal SalarioBase;
        public decimal ValorDasVendas;
        public decimal Comissao;
        public decimal CalculoDeSalarioComComissao()
        {
           return (SalarioBase) + (ValorDasVendas) * (Comissao / 100);
        }
    }
}
