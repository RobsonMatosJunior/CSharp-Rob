using System;

namespace Csharp_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Valor1= Console.ReadLine().Split(' ');
            decimal a = decimal.Parse(Valor1[0]);
            decimal b = decimal.Parse(Valor1[1]);
            decimal c = decimal.Parse(Valor1[2]);

            string[] Valor2= Console.ReadLine().Split(' ');
            decimal d = decimal.Parse(Valor2[0]);
            decimal e = decimal.Parse(Valor2[1]);
            decimal f = decimal.Parse(Valor2[2]);

            decimal resultado = (b * c) + (e * f);
            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2"));
        }

    }
}