

// Problemas While

// Problema = 1114
/*
using System;
class Program
{
    static void Main (string [] args)
    {
        int senha = 2002;
        int entrada = int.Parse(Console.ReadLine());
        int cont = 0;
        while (entrada != senha)
        {
            cont = cont + 1;
            Console.WriteLine("Senha Invalida");
            entrada = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Acesso Permitido");
        Console.WriteLine("Tentativas até o sucesso: " + cont);
    }
}
*/

// PROBLEMA = 1115

using System;
class Program
{
    static void Main (string [] args)
    {
        int x, y;
        string [] valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);

        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
                
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
                
            }
            else if ( x< 0 && y > 0)
            {
                Console.WriteLine("terceiro");
            }
            else
            {
                Console.WriteLine("quarto");
                
            }
            valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
        }
        Console.ReadLine();
    }
}