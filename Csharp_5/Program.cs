// Váriavel a Recebe a raiz quadrada de X
//A = Math.Sqrt(x);

// Variável A recebe o resultado de X elevado a Y
//A = Math.Pow(x,y);

//Variável A recebe o valor absoluto de X
//A = Math.Abs(x);


 using System;
 using System.Globalization; 

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            System.Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            System.Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            System.Console.WriteLine("Raiz quadrada de 25 = " + C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);

            Delta = Math.Pow(B,2.0) - 4*A*C;
            X1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
            X2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);  

            
            Console.ReadLine();
        } 
    }
}
