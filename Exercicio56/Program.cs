using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números
            pares e de múltiplos de 5.*/

            int[] _numPos = new int[50];
            int numPares = 0;
            int numMult5 = 0;
            int numPos = 0;

                Console.WriteLine("\nInforme 50 números inteiros e positivos:");

                for (int i = 0; i < 50; i++)
                {
                    while (true)
                    {
                        Console.Write($"Posição {i + 1}: ");
                        string inputnum = Console.ReadLine();

                        if (string.IsNullOrEmpty(inputnum) || !int.TryParse(inputnum, out numPos))
                        {
                            Console.WriteLine("Erro: Insira um número inteiro e positivo");
                            continue;
                        }
                        _numPos[i] = numPos;
                        break;
                    }
                          
                }

            numPares = _numPos.Count(n => n % 2 == 0);
            numMult5 = _numPos.Count(n => n % 5 == 0);

            Console.WriteLine($"\nA quantidade de números pares é de {numPares}  e de múltiplos de 5 e {numMult5}");
            Console.ReadLine();
        }
    }
}
