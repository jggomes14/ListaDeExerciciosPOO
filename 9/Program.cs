namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Média Harmonica");
            Calculo media = new Calculo();
            Console.WriteLine("Insira a nota 1");
            media.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a nota 2");
            media.nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a nota 3");
            media.nota3 = Convert.ToDouble(Console.ReadLine());
            double notaHarmonica = media.Harmonica();
            Console.WriteLine("A Média Harmônica é" + notaHarmonica);
        }
    }
}