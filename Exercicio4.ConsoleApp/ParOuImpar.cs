using System;

namespace Exercicio4.ConsoleApp
{
    internal class ParOuImpar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("é par");
            }
            else
            {
                Console.WriteLine("é impar");
            }





        }
    }
}
