using System;

namespace Exercicio1_Lista2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            double soma = A + B;

            if (soma < C)
            {
                Console.WriteLine("A soma de A e B é igual a: " + soma + ", ela é menor que C!");
            }
            else
            {
                Console.WriteLine("A soma de A e B é igual a: " + soma + ", ela é maior que C!");
            }


        }
    }
}
