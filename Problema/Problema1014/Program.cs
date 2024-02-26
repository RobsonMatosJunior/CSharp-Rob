using System;
    class Program
    {
        static void Main(string[] args)
        {
            int distancia  = int.Parse(Console.ReadLine());
            decimal combustivel = decimal.Parse(Console.ReadLine());
            decimal consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString("F3") + " km/l");
            Console.ReadLine();

        }
    }
