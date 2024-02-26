using System;
class Program
{
    static void Main()
    {
        double Raio, Pi, Volume;
        Raio = double.Parse(Console.ReadLine());
        Pi = 3.14159;
        Volume = (4.0 / 3) * Pi * Math.Pow(Raio, 3);
        Console.WriteLine("VOLUME = " + Volume.ToString("F3"));
        Console.ReadLine();
    }
}


