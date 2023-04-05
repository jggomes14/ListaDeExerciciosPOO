namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos Calcular o Volume de um Cilindro");
            Calculo Cilindro = new Calculo();
            Console.ReadKey();
            Console.WriteLine("Insira a altura do cilindro");
            Cilindro.altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o raio do cilindro");
            Cilindro.raio = Convert.ToInt32(Console.ReadLine());
            double Volume = Cilindro.VolumeDeUmCilindro();
        }
    }
}