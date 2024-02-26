﻿using System;
class Program
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);
        double Pi = 3.14159;

        double areaTriangulo = (A * C) / 2;
        double areaCirculo = Pi * Math.Pow(C, 2);
        double areaTrapezio = ((A + B) * C) / 2;
        double areaQuadrado = Math.Pow(B, 2);
        double areaRetangulo = A * B;

        Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));
        Console.ReadLine();
    }
}
