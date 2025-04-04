using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio46
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exibe uma mensagem pedindo ao usuário para informar a quantidade de elementos dos vetores x e y.
            Console.WriteLine("Informe a quantidade de elementos dos vetores x e y: ");

            int n; // Declara uma variável para armazenar o número de elementos.

            // Loop para validar a entrada do usuário.
            while (true)
            {
                // Tenta converter a entrada do usuário para um número inteiro.
                // Se a conversão falhar ou se o número for menor ou igual a zero, exibe uma mensagem de erro.
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Por favor, insira um número inteiro positivo.");
                }
                else
                {
                    // Se a entrada for válida, sai do loop.
                    break;
                }
            }

            // Cria dois vetores inteiros com o tamanho especificado pelo usuário.
            int[] x = new int[n];
            int[] y = new int[n];

            // Solicita ao usuário que insira os elementos do vetor x.
            Console.WriteLine("Informe os elementos do vetor x:");
            for (int i = 0; i < n; i++) // Loop para preencher o vetor x.
            {
                Console.Write($"x[{i}]: "); // Exibe o índice atual do vetor.
                x[i] = int.Parse(Console.ReadLine()); // Lê e armazena o valor fornecido pelo usuário no vetor x.
            }

            // Solicita ao usuário que insira os elementos do vetor y.
            Console.WriteLine("Informe os elementos do vetor y:");
            for (int i = 0; i < n; i++) // Loop para preencher o vetor y.
            {
                Console.Write($"y[{i}]: "); // Exibe o índice atual do vetor.
                y[i] = int.Parse(Console.ReadLine()); // Lê e armazena o valor fornecido pelo usuário no vetor y.
            }

            // Inicializa a variável que armazenará o produto escalar.
            int produtoEscalar = 0;

            // Calcula o produto escalar dos vetores x e y.
            for (int i = 0; i < n; i++) // Loop para percorrer os vetores.
            {
                // Multiplica os elementos correspondentes de x e y e adiciona ao produto escalar.
                produtoEscalar += x[i] * y[i];
            }

            // Exibe o resultado do produto escalar.
            Console.WriteLine($"O produto escalar dos vetores x e y é: {produtoEscalar}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }

    }
