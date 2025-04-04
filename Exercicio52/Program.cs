
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para armazenar os números inseridos pelo usuário
            List<int> list_numeros = new List<int>();

            // Contadores para os números 1, 3 e 4
            int count1 = 0, count3 = 0, count4 = 0;

            Console.WriteLine("\nInsira uma sequência de no máximo 100 números inteiros e positivos. Para encerrar a sequência digite -1");

            // Loop para receber os números do usuário até atingir 100 entradas ou o usuário digitar -1
            while (list_numeros.Count < 100)
            {
                string sequencia = Console.ReadLine();

                // Validação da entrada: verifica se é um número inteiro válido e se não é menor que -1
                if (string.IsNullOrEmpty(sequencia) || !int.TryParse(sequencia, out int numeros) || numeros < -1)
                {
                    Console.WriteLine("\nErro: Insira números inteiros e positivos.");
                    continue;
                }

                // Se o usuário digitar -1, o programa encerra a coleta de dados
                if (numeros == -1)
                {
                    Console.WriteLine("\nEncerrando a operação...");
                    break;
                }

                // Adiciona o número válido à lista
                list_numeros.Add(numeros);

                // Contabiliza a ocorrência dos números 1, 3 e 4
                if (numeros == 1) count1++;
                else if (numeros == 3) count3++;
                else if (numeros == 4) count4++;
            }

            // Exibe a contagem de ocorrências dos números 1, 3 e 4
            Console.WriteLine("\nQuantidade de vezes que aparece:");
            Console.WriteLine($"1: {count1}");
            Console.WriteLine($"3: {count3}");
            Console.WriteLine($"4: {count4}");

        }
    }
}
