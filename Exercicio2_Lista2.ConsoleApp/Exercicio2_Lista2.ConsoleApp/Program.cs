using System;

namespace Exercicio2_Lista2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[3];
            int maior = 0;
            int menor = 999999999;
            int meio = 1;


            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Digite o valor: ");
                    valor[i] = Convert.ToInt32(Console.ReadLine());

                    if (valor[i] > maior)
                    {
                        maior = valor[i];
                    }
                    if (valor[i] < menor)
                    {
                        menor = valor[i];
                    }
                    
                }
                for (int i = 0;i < 3; i++)
                {
                    if (valor[i] > menor && valor[i] < maior)
                    {
                        meio = valor[i];
                    }
                }
                } while (valor[0] == valor[1] || valor[0] == valor[2] || valor[1] == valor[2]) ;

                 Console.WriteLine("Valores em ordem decrescente: " + maior + " " + meio + " " + menor);
               
            }

            }
    }

    


