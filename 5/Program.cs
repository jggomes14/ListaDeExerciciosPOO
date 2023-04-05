namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Para Calcular o Volume de Uma Esfera");
            Calculo calculo = new Calculo();
            Console.WriteLine("Insira o valor do Raio da Esfera");
            calculo.raio = Convert.ToInt32(Console.ReadLine());
            double Volume = calculo.Esfera();
        }
    }
}