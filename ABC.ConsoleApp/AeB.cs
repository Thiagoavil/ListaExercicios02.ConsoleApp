using System;

namespace ABC.ConsoleApp
{
    internal class AeB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                int c = a + b;
                Console.WriteLine("o resultado é: " + c);
            }
            else if (b != a)
            {
                int c = a * b;
                Console.WriteLine("O resultado é: " + c);
            }

        }
    }
}
