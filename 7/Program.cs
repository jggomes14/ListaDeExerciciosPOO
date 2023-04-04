namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Salário com Comissão de Venda");
            Calculo salario = new Calculo();    
            salario.CalculoDeSalarioComComissao();
        }
    }
}