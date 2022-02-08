using System;

namespace Exercicio3.ConsoleApp
{
    internal class IMC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo do IMC ");
            Console.WriteLine("Digite seu peso:");
            double peso =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua aultura: ");
            double altura =Convert.ToDouble(Console.ReadLine());

            double IMC = peso * altura * altura;

            if (IMC < 18.5)
            {
                Console.WriteLine("Está a baixo do peso ");
            }
            else if (IMC >= 18.5 || IMC <= 25) 
            {
                Console.WriteLine("Está no Peso ideal ");
            }
            else if (IMC > 25 || IMC <= 30) 
            {
                Console.WriteLine("Está a cima do peso");
            }
            else if (IMC > 30)
            {
                Console.WriteLine("Obeso ");
            }

        }
    }
}
