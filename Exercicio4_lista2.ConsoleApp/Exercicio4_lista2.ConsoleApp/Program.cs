using System;

namespace Exercicio4_lista2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = System.Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero " + numero + " é par!");
            }
            else
            {
                Console.WriteLine("O numero " + numero + " é ímpar!");
            }
        }
    }
}
