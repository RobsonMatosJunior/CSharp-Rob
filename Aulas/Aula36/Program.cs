﻿using System;
class program
{
    static void Main(string[] args)
    {
        int minutos;
        double conta;

        minutos = int.Parse(Console.ReadLine());
        conta = 50.0;
        if (minutos > 100)
        {
            conta = conta + (minutos - 100) * 2.0;
            
        }
        Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"));
        Console.ReadLine();
    }
}