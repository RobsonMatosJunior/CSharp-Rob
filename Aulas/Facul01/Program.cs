/*
namespace Quest02_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 2; // Declaração de variáveis

            // Atribuição
            a = 5;

            // Mostra o resultado
            Console.WriteLine("O resultado é: " + a % b);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}

using System;
namespace Quest02_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis do tipo float
            float f1;
            float f2 = 60.229f;

            // Atribui valor
            f1 = 50.1249f;

            // Mostra valores
            Console.WriteLine("O valor de f1 é: {0:F2}", f1);
            Console.WriteLine("O valor de f2 é: {0:F2}", f2);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}

using System;
namespace Quest02_Q09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            double a1, a2, a3;
            bool t1, t2;

            // Resultados
            Console.Write("Forneça o primeiro valor: ");
            t1 = double.TryParse(Console.ReadLine(), out a1);
            Console.Write("Forneça o segundo valor: ");
            t2 = double.TryParse(Console.ReadLine(), out a2);

            a3 = 2 * a1 + a2 / 2;

            Console.WriteLine("A resposta é {0}", a3);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}

using System;
namespace Quest02_007
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara variáveis
            float nf, resFloat;

            // Recebe um valor
            Console.Write("Forneça o preço: ");
            nf = float.Parse(Console.ReadLine());

            // Atribui valor
            resFloat = nf + 10.5;

            // Informa os valores
            Console.WriteLine("O preço {0:C} e o novo {1:C}", nf, resFloat);

            // Mantém a tela aberta esperando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}

using System;

namespace Quest02_Q06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            char valor;

            // Recebe valor
            Console.Write("Digite um valor qualquer: ");
            valor = Console.Read();

            // Exibe o código do caractere
            Console.WriteLine("O código do caractere é: " + valor);

            // Mantém a tela aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}

using System;
namespace Quest02_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declara variáveis tipo Char e String
            char c1;
            String c2; 
            String c3, c4;

            // Atribui valores
            c1 = 'C';
            c2 = "Certo";
            c3 = "13";
            c4 = "91112345";

            // Mostra valores
            Console.WriteLine("O valor de c1 é: " + c1);
            Console.WriteLine("O valor de c2 é: " + c2);
            Console.WriteLine("O valor de c3 concatenado com c4: é " + c3 + c4);

            // Mantém a tela aberta esperando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}

namespace Quest03_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            double v, vo, t;

            // Fornecimento da velocidade inicial
            Console.Write("Qual a velocidade inical? ");
            vo = double.Parse(Console.ReadLine());

            // Atribuição de valores para iniciar o Wile
            t = 0;
            v = vo;

            // Calculos
            while (v > 0)
            {
                t = t + 1;
                v = vo - 10 * t;               
                if (v >= 0)
                {
                    Console.WriteLine("Após {0} segundos, a velocidade é {1} ", t, v);
                }
                if (v < 0)
                {
                    Console.WriteLine("O carro para entre {0} e {1} segundos", t - 1, t);
                    break;
                }
            }
            if (v >= 0)
            {
                Console.WriteLine("O carro para após {0} segundos", t);
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace tester04
{
    class Program
    {
        static void Main(string[] args)
        {
            int digi;
            do
            {
                Console.Write("Digite: ");
                digi = int.Parse(Console.ReadLine());
            }
            while (digi % 2 != 0);
            Console.ReadKey();

        }
    }
}


namespace Quest02_Q09
{
    internal class program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            double a1, a2, a3;
            bool t1, t2;

            // Resultado
            Console.WriteLine("Forneça o primeiro valor:");
            t1 = double.TryParse(Console.ReadLine(), out a1);
            Console.WriteLine("Forneça o segundo valor:");
            t2 = double.TryParse(Console.ReadLine(), out a2);
            a3 = 2 * a1 + a2 / 2;
            Console.WriteLine("O resultado é {0} ", + a3);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}



namespace Quest02_Q08
{
    internal class program
    {
        void Main(string[] args)
        {
            // Declaração de variáveis
            int a, b = 2;

            // Atrobiuição
            a = 5;

            // Mostra o resultado
            Console.WriteLine("O resultado é: " + a%b);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        
        }
    } 
}



namespace Quest02_Q06
{
    internal class program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            char valor;

            // Recebe valor
            Console.WriteLine("Digite um valor qualquer: ");
            valor = Console.Read();
            
            Console.WriteLine("O código do caractér é: " + valor);
            
            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}



using System;
namespace Quest02_Q04
{
    internal class program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            char c1;
            string c2;
            string c3, c4;

            // Atribui valores
            c1 = "C"
            c2 = "Certo"
            c3 = "13"
            c4 = "91112345"

            // Mostra valores
            Console.WriteLine("O valor de c1 é: " + c1);
            Console.WriteLine("O valor de c2 é: " + c2);
            Console.WriteLine("O valor de c3 concatenado com c4: é " + c3 + c4 );

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}



using System;
namespace Quest02_Q02
{
    internal class program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
           float f1;
           float f2 = 60.229;

           // Atribui valores
           f1 = 50.1249;

           // Mostra valores
           Console.WriteLine("O valor de f1 é: {0:F2}", + f1);
           Console.WriteLine("O valor de f2 é: {0:F2}", + f2);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}




using System;
namespace Quest02_Q07
{
    internal class program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
           float nf, resFloat;

           // recebe u7m valor
           Console.WriteLine("Forneça o preço: ");
           nf = float.Parse(Console.ReadLine());

           // Atribui valor
           resFloat = nf + 10.5;
           
           // Mostra valores
           Console.WriteLine("O preço {0:C} e o novo {1:C} ", nf, resFloat);

            // Mantém a tela aberta aguardando a digitação de uma tecla
            Console.ReadKey();
        }
    }
}
*/
