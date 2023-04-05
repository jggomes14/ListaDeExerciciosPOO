namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Conversor de Fahrenheint para Celsius!");
            Console.WriteLine("Aperte qualquer botão para continuar");
            Console.ReadKey();
            Temperatura temperatura = new Temperatura();
            Console.WriteLine("Insira a temperatura em Fahrenheint");
            temperatura.TemperaturaFahrenheit = Convert.ToInt32(Console.ReadLine());
            double Temp = temperatura.ConversorParaCelsius();
            Console.WriteLine($"A temperatura em Celsius {Temp} °C");
        }
    }
}