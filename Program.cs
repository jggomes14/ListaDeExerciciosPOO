namespace ListaDeExerciciosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o volume da caixa retangular");
            CaixaRetangular caixa = new CaixaRetangular();
            caixa.CalcularVolume();
        }
    }
}