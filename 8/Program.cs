namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o volume de uma lata");
            Calculo lata = new Calculo();
            Console.WriteLine("Insira o raio da lata");
            lata.raio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a altura da lata");
            lata.altura = Convert.ToInt32(Console.ReadLine());
            double Volume = lata.Volume();
            Console.WriteLine($"O Volume da Lata é {Volume}");

        }
    }
}