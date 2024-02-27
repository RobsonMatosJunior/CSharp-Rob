using System;

namespace Csharp_9
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());

            double comissao = totalVendas * 0.15;
            double totalReceber = salarioFixo + comissao;

            Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2"));
            Console.ReadLine();

        }
    }
}
