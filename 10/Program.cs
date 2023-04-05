namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Média Ponderada");
            Calculo media = new Calculo();
            Console.WriteLine("Insira a nota da prova 1");
            media.prova1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a nota da prova 2");
            media.prova2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso da prova 1");
            media.peso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso da prova 2");
            media.peso2 = Convert.ToDouble(Console.ReadLine());
            media.Ponderada();
            double NotaPonderada = media.Ponderada();

            Console.WriteLine("A média ponderada do aluno em questão é " + NotaPonderada);
        }
    }
}