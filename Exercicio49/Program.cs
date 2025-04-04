using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio49
{
    internal class Program
    {
        // Função principal do programa
        static void Main(string[] args)
        {
            // Declaração dos vetores para armazenar os números
            // Cada vetor pode armazenar até 50 números inteiros
            int[] _V1 = new int[50];
            int[] _V2 = new int[50];

            // Variáveis para controlar o número real de entradas em cada vetor
            // Estas variáveis ajudam a rastrear quantos números foram efetivamente inseridos
            int countV1 = 0;
            int countV2 = 0;

            // Mensagem inicial para o usuário sobre a entrada da primeira sequência
            Console.WriteLine("\nInsira a Primeira sequência de números (máximo 50) ou pressione <ENTER> para encerrar a primeira sequência:");

            // Laço para capturar os números do primeiro vetor
            for (int i = 0; i < 50; i++)
            {
                // permite e mostra a posição do número que está sendo inserido
                Console.Write($"Número_{i + 1} = ");
                string input = Console.ReadLine();

                // Verifica se o usuário pressionou <ENTER> sem digitar nada
                if (string.IsNullOrEmpty(input))
                {
                    // Encerra a entrada de dados para o primeiro vetor
                    Console.WriteLine("\nEncerrando a primeira sequência...");
                    break;
                }

                // Tenta converter a entrada para um número inteiro e verifica se é maior que zero
                if (!int.TryParse(input, out int V1) || V1 <= 0)
                {
                    // Exibe uma mensagem de erro se a entrada for inválida ou não for positiva
                    Console.WriteLine("\nErro: número inválido! Informe um número positivo maior que ZERO.");
                }
                else
                {
                    // Armazena o número no vetor junto com o seu endereço(_V1[countV1]) e incrementa o contador(countV1++)
                    _V1[countV1] = V1;
                    countV1++;
                }
            }

            // Mensagem inicial para o usuário sobre a entrada da segunda sequência
            Console.WriteLine("\nInsira a Segunda sequência de números (máximo 50) ou pressione <ENTER> para encerrar a segunda sequência:");

            // Laço para capturar os números do segundo vetor
            for (int i = 0; i < 50; i++)
            {
                // permite e mostra a posição do número que está sendo inserido
                Console.Write($"Número_{i + 1} = ");
                string input2 = Console.ReadLine();

                // Verifica se o usuário pressionou <ENTER> sem digitar nada
                if (string.IsNullOrEmpty(input2))
                {
                    // Encerra a entrada de dados para o segundo vetor
                    Console.WriteLine("\nEncerrando a segunda sequência...");
                    break;
                }

                // Tenta converter a entrada para um número inteiro e verifica se é maior que zero
                if (!int.TryParse(input2, out int V2) || V2 <= 0)
                {
                    // Exibe uma mensagem de erro se a entrada for inválida ou não for positiva
                    Console.WriteLine("\nErro: número inválido! Informe um número positivo maior que ZERO.");
                }
                else
                {
                   // Armazena o número no vetor junto com o seu endereço(_V2[countV2]) e incrementa o contador(countV2++)
                    _V2[countV2] = V2;
                    countV2++;
                }
            }

            // Determinar o menor comprimento entre os dois vetores
            // Isso garante que só comparamos até onde ambos os vetores têm valores válidos ou seja se  um tiver 5 número registrados e o outro tiver 20 isso
            // fará que seja analisado somente até 5 posiçoes dos 2 vetores.
            int minLength = Math.Min(countV1, countV2);

            // Variável para contar quantos valores são idênticos nas mesmas posições
            int identicalCount = 0;

            // Laço para comparar os valores dos dois vetores
            for (int i = 0; i < minLength; i++)
            {
                // Verifica se os valores na mesma posição dos dois vetores são iguais
                if (_V1[i] == _V2[i])
                {
                    // contar quantas vezes os números nas mesmas posições dos dois vetores são iguais exemplo: se for localizado 1 numero em comum ele conta 1,
                    // se achar mais número em comum vai contando +1 até o termino do processamento
                    identicalCount++;

                    // Exibe a posição e o valor que são idênticos
                    Console.WriteLine($"\n***Posição {i + 1}= número {_V1[i]} é idêntico em ambas as sequências.***");
                    //Observação i: Representa o índice atual do vetor, começando em 0,
                    //i + 1: Ajusta a exibição para uma contagem que começa em 1, exemplo de a posição denro do sistema for 4 mas o rsultado está visulmente para o usuário na 5 , {i + 1} fará que isso seja ajustado
                }
            }

            // Exibe o resultado final para o usuário
            // Mostra quantos valores idênticos foram encontrados nas mesmas posições
            Console.WriteLine($"\nTotal de valores idênticos nas mesmas posições: {identicalCount}");
            Console.ReadKey();
        }

    }
}
