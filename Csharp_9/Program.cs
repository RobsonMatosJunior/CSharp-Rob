using System;

namespace Csharp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Raio, Area, Pi;
            Raio = double.Parse(Console.ReadLine());
            Pi = 3.14159;
            Area = Pi * Math.Pow(Raio, 2);
            Console.WriteLine("A= " + Area.ToString("F4"));
            Console.ReadLine();

        }
    }
}
