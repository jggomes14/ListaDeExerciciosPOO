namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Consumo de Combustivel por Km");
            Calculo calculo = new Calculo();
            Console.WriteLine("Insira a Quilometragem Inicial do Veiculo");
            calculo.KmInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a Quilometragem Final do Veiculo");
            calculo.KmFinal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Consumo de Combustivel ao final do percurso");
            calculo.ConsumoDeCombustivel = Convert.ToInt32(Console.ReadLine());
            double Calculo = calculo.CalculoDeCombustivel();

        }
    }
}