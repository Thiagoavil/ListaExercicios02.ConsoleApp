using System;

namespace Exercicio2.ConsoleApp
{
    internal class Decrescente
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Digite o teceiro valor: ");
            int c = Convert.ToInt32(Console.ReadLine());


            if (a >= b && a >= c && b >= c)
            {
                Console.WriteLine("A ordem decrescente é "+ a + " " + b + " " + c);

            }
            else if (a >= b && a >= c && c>= b)
            {
                Console.WriteLine("A ordem decrescente é " + a + " " + c + " " + b);
            }
            else if (b >= a && b >= c && a >= c)
            {
                Console.WriteLine("A ordem decrescente é " + b + " " + a + " " + c);
            }
            else if (b >= a && b >= c && c >= a )
            {
                Console.WriteLine("A ordem decrescente é " + b + " " + c + " " + a);
            }
            else if (c >= a && c >= b && a >= b)
            {
                Console.WriteLine("A ordem decrescente é " + c + " " + a + " " + b);
            }
            else if (c >= a && c >= b && b>= a )
            {
                Console.WriteLine("A ordem decrescente é " + c + " " + b + " " + a);
            }


        }

    }
}
