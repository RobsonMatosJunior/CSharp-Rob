using System;
/*
class Program
{
    static void Main(string [] strings)
    {
        int x, y;
        x = 0;
        y = 4;

        while(x < 3)
        {
            y = y + 2;
            x = x + 1;
            Console.WriteLine("x = " + x + " y = " + y);
        }
    }
}
*/
/* 
class Program
{
    static void Main(string [] args)
    {
        int x, y;
        x = 5;
        y = 0;

        while (x > 2)
        {
            Console.WriteLine(x);
            y = y + x;
            x = x - 1;
        }

    }
}
*/
/*
class Program
{
    static void Main(string [] args)
    {
        int x, y;
        x = 2;
        y = 0;

        while (x < 60)
        {
            Console.WriteLine(x);
            x = x * 2;
            y = y + 10;
        }
    }
}
*/
/*
class Program
{
    static void Main(string [] args)
    {
        double x, y;
        x = 100;
        y = 100;

        while (x != y)
        {
            // Exercicio com problema de lógica para validar a condição.
            x = Math.Sqrt(y);
            Console.WriteLine("Olha o valor de X: " + x + " e o valor de Y: " + y);
        }
    }
}
*/
class Program
{
    static void Main(string [] args)
    {
        int x, y;
        x = 0;

        while (x < 5)
        {
            y = x * 3;
            Console.WriteLine(y);
            x = x + 1;
        }
        Console.WriteLine("Fim");
    }
}