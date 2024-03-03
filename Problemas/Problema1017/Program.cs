using System;
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;
            double litros = distancia / 12;

            Console.WriteLine(litros.ToString("F3"));
            Console.ReadLine();
        }
    }