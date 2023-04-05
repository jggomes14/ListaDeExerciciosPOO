namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Salário com Comissão de Venda");
            Calculo salario = new Calculo();
            Console.WriteLine("Insira o seu salário base");
            salario.SalarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas do mês");
            salario.ValorDasVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de comissão?");
            salario.Comissao = Convert.ToDecimal(Console.ReadLine());
            decimal Salario = salario.CalculoDeSalarioComComissao();
            Console.WriteLine($"O Salário desse mês é de {Salario}");
        }
    }
}