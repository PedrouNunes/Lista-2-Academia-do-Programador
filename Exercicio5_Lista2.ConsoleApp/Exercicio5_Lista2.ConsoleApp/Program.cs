using System;

namespace Exercicio5_Lista2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double A = System.Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double B = System.Convert.ToDouble(Console.ReadLine());

            double C;

            if (A == B)
            {             
                 C = A + B;
                Console.WriteLine("A equação foi uma soma! O resultado é: " + C);
            }
            else
            {
                C = A * B;
                Console.WriteLine("A equação foi uma multiplicação! O resultado é: " + C);
            }
        }
    }
}
