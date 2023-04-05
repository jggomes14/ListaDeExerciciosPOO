namespace ListaDeExerciciosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o volume da caixa retangular");
            CaixaRetangular caixa = new CaixaRetangular();
            Console.WriteLine("Insira o Comprimento");
            caixa.Comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o Largura");
            caixa.Largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o Altura");
            caixa.Altura = Convert.ToDecimal(Console.ReadLine());
            decimal Volume = caixa.CalcularVolume();
            Console.WriteLine("O Volume da Caixa Retangular é " + Volume + "L");
        }
    }
}