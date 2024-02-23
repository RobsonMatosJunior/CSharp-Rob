using System;
using System.Globalization;

namespace Csharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questionnaire
            Console.WriteLine("Entre com seu nome!");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos Quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto!");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Answer + content
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Em sua casa tem: " + quartos + " quartos!");
            Console.WriteLine("O preço do produto é: " + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

