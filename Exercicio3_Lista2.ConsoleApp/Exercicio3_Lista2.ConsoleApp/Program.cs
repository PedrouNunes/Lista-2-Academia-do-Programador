using System;

namespace Exercicio3_Lista2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal peso, altura, imc;

            const decimal abaixo = 18.5m;
            int entre = 25;
            int acima = 30;

            Console.Write("Digite o peso da pessoa em Kg: ");
            peso = System.Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura da pessoa em metros: ");
            altura = System.Convert.ToDecimal(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < abaixo)
            {
                Console.WriteLine("Abaixo do peso ideal!");
            }
            else
            {
                if (imc > abaixo && imc < entre)
                {
                    Console.WriteLine("Peso ideal!");
                }
                else
                {
                    if (imc > entre && imc < acima)
                    {
                        Console.WriteLine("Acima do peso ideal!");
                    }
                    else
                    {
                        if (imc > acima)
                        {
                            Console.WriteLine("Obeso(a)!");
                        }
                    }
                }
            }
        }
    }
}
