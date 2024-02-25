using System;
using System.Globalization;

namespace Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double Largura, Comprimento, PrecoMetroQuadrado, Area, Preco;

            Console.WriteLine("Digite a Largura no formato 00.00:");
            Largura  = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture); //Recebe o valor da Largura
            
            Console.WriteLine("Digite o comprimento no formato 00.00:");
            Comprimento = double.Parse(Console.ReadLine().Replace(",", "."),CultureInfo.InvariantCulture); //Recebe o valor do Comprimento
            
            Console.WriteLine("Digite o Preço do Metro quadrado no formato 000.00:");
            PrecoMetroQuadrado = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture); //Recebe o valor do Preço por metro quadrado

            Area = Largura * Comprimento; //Calcula a área
            Preco = Area * PrecoMetroQuadrado; //Calcula o preço da área

            System.Console.WriteLine("Área = " + Area.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Preço = " + Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();


          
       }

    }

}
