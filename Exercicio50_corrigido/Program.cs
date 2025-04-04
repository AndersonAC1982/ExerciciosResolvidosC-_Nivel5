using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio50_corrigido
{
    internal class Program
    {
            static void Main(string[] args)
            {
            // Número premiado fixo (ORIGINAL)
            // int num_prem = 10;

            // Sorteia um número entre 0 e 100 (ALTERADO)
            int num_prem = new Random().Next(0, 101); // Alterado para atender ao enunciado de sorteio aleatório.

            // Array com tamanho 0 (ORIGINAL)
            // int[] tentat = new int[0];

            // Array com capacidade suficiente para armazenar tentativas (ALTERADO)
            int[] tentat = new int[100]; // Alterado para evitar erros ao armazenar tentativas.

            int count_tent = 0;

            while (true) // Alterado para um loop contínuo até o número ser acertado.
            {
                Console.Write("\nInforme seu palpite: ");
                string _palpi = Console.ReadLine();

                // Validação básica da entrada (ORIGINAL)
                // if (string.IsNullOrEmpty(_palpi))
                // {
                //     Console.WriteLine("Erro: informe um número de 0 a 100");
                //     continue;
                // }

                // Verifica se a entrada é válida e está no intervalo correto (ALTERADO)
                if (string.IsNullOrEmpty(_palpi) || !int.TryParse(_palpi, out int palpi) || palpi < 0 || palpi > 100)
                {
                    Console.WriteLine("Erro: Informe um número válido entre 0 e 100."); // Ajustado para validar o intervalo e a entrada.
                    continue;
                }

                // Armazena a tentativa no array (ALTERADO)
                tentat[count_tent] = palpi; // Corrigido para armazenar a tentativa no array.
                count_tent++;

                // Condição para verificar se o número está correto (ORIGINAL)
                // if (palpi != num_prem)
                // {
                //     if (palpi < num_prem)
                //     {
                //         Console.WriteLine($"\nO número premiado é maior que o seu palpite {palpi}");
                //     }
                //     else
                //     {
                //         Console.WriteLine($"\nO número premiado é menos que o seu palpite {palpi}");
                //     }
                //     Console.ReadKey();
                //     break;
                // }

                // Condição para verificar se o número está correto (ALTERADO)
                if (palpi != num_prem)
                {
                    if (palpi < num_prem)
                    {
                        Console.WriteLine($"\nO número premiado é maior que o seu palpite {palpi}");
                    }
                    else
                    {
                        Console.WriteLine($"\nO número premiado é menor que o seu palpite {palpi}"); // Corrigido "menos que" para "menor que".
                    }
                }
                else
                {
                    // Mensagem de acerto e quantidade de tentativas (ALTERADO)
                    Console.WriteLine($"\nParabéns! Você acertou o número {num_prem}.");
                    Console.WriteLine($"Você precisou de {count_tent} tentativas.");
                    break; // Encerra o loop quando o número é acertado.
                }
            }

            Console.ReadKey();   
        }
    }
}
