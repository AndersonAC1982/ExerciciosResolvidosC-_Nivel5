using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir
            também o maior. A quantidade de números lidos será definida pelo usuário.*/

            int quantidade = 0;

            while (true)
            {
                Console.WriteLine("\nInforme a quantidade de números a ser lidos: ");
                string n = Console.ReadLine();


                if (string.IsNullOrEmpty(n) || (!int.TryParse(n, out quantidade) || quantidade <= 0))
                {
                    Console.WriteLine("\nErro: Valor incorreto. Infome um número inteiro e positivo");

                }
                else 
                {
                    break; 
                }
            }

            int[] _num = new int[quantidade];

            Console.WriteLine("\nInforme os números: ");


            for (int i = 0; i < quantidade; i++)
            {
                while (true)
                {
                    string inputNumeros = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputNumeros) || !int.TryParse(inputNumeros, out int numeros) && numeros < 0)
                    {
                        Console.WriteLine("\nErro: informe um número inteiro e positivo");
                        continue;
                    }

                    _num[i] = numeros;
                    break;
                }
            }
                double media = _num.Average();
                int max = _num.Max();

                Console.WriteLine($"\nA media é: {media}");
                Console.WriteLine($"\nO número máximo é: {max}");

            Console.ReadKey();

        }
    }
}
