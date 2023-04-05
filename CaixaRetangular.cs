using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosPOO
{
    internal class CaixaRetangular
    {
        public decimal Comprimento;
        public decimal Largura;
        public decimal Altura;

        public decimal CalcularVolume()
        {
         
            return Comprimento * Largura * Altura;
            
        }
    }
}

