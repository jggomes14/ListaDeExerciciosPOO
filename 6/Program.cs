namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura Celsius para Fahrenheint");
            Calculo temperatura = new Calculo();
            Console.WriteLine("Insira a temperatura em Celsius");
            temperatura.TemperaturaCelsius = Convert.ToInt32(Console.ReadLine());
            double Temp = temperatura.ConversorParaFahrenreint();
            Console.WriteLine($"A temperatura em Fahrenreint {Temp} °F");
        }
    }
}