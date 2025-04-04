using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio54_corrigido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] _A = new int[5];
            int[] _B = new int[8];

            Console.WriteLine("\nInsira 5 elementos para o conjunto A");
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    string input_A = Console.ReadLine();

                    if (string.IsNullOrEmpty(input_A) || !int.TryParse(input_A, out int A))
                    {
                        Console.WriteLine("Erro: Insira um elemento válido");
                        continue;
                    }

                    _A[i] = A; // Armazena o valor no array
                    break; // Sai do loop após uma entrada válida
                }
            }

            Console.WriteLine("\nInsira 8 elementos para o conjunto B");
            for (int i = 0; i < 8; i++)
            {
                while (true)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    string input_B = Console.ReadLine();

                    if (string.IsNullOrEmpty(input_B) || !int.TryParse(input_B, out int B))
                    {
                        Console.WriteLine("Erro: Insira um elemento válido");
                        continue;
                    }

                    _B[i] = B; // Armazena o valor no array
                    break; // Sai do loop após uma entrada válida
                }
            }

            // Encontrar elementos comuns entre A e B
            // O método .Intersect() compara os dois arrays e retorna apenas os valores que aparecem nos dois
            // .ToArray() converte o resultado (que é um IEnumerable<int>) para um array (int[]), facilitando a manipulação posterior
            int[] comuns = _A.Intersect(_B).ToArray();

            // Verificar se existem elementos comuns
            if (comuns.Length > 0)
            {
                // Exibir os elementos comuns
                // string.Join(", ", comuns) junta os elementos do array "comuns" em uma única string, separando-os por ", "
                Console.WriteLine("\nOs elementos comuns entre A e B são: " + string.Join(", ", comuns));
            }
            else
            {
                // Caso não haja elementos comuns, exibir uma mensagem informativa
                Console.WriteLine("\nNão há elementos comuns entre A e B.");
            }

            Console.ReadKey();
        }
    }
}
