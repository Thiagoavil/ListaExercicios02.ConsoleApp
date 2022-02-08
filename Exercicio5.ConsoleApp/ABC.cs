using System;

namespace Exercicio5.ConsoleApp
{
    internal class ABC
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite o valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            double C = Convert.ToDouble(Console.ReadLine());


            if (A + B < C)
                Console.WriteLine("A soma de A + B é menor que C ");

            else
            {
                Console.WriteLine("A soma de A + B é Menor ou Igual a C");
            }
        }
    }
}
