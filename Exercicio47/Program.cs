using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicio47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                // Exibe uma mensagem pedindo ao usuário para informar o valor de X.
                Console.Write("\nInforme o valor de X: ");

                // Tenta ler e converter o valor digitado pelo usuário para um número inteiro.
                // Verifica se a entrada é válida (um número inteiro positivo maior que zero).
                if (!int.TryParse(Console.ReadLine(), out int valor_X) || valor_X <= 0)
                {
                    // Se o valor for inválido (não é um número ou é menor ou igual a zero),
                    // exibe uma mensagem de erro e encerra o programa.
                    Console.WriteLine("\nErro: informe um número inteiro positivo maior que zero.\n");
                    continue;
                }

                // Declara um vetor de inteiros com 10 posições.
                int[] numeros = new int[10];
                Console.WriteLine("Informe os 10 números inteiros positivos maiores que zero:");

                // Um loop para preencher o vetor com 10 números fornecidos pelo usuário.
                for (int i = 0; i < 10; i++)
                {
                    while (true) // Loop para garantir que o número digitado seja válido.
                    {
                        Console.Write($"Número {i + 1}: "); // Exibe a posição atual para o usuário.
                                                            // Tenta converter a entrada do usuário para um número inteiro.
                        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
                        {
                            // Se o número for válido (inteiro positivo maior que zero), armazena no vetor.
                            numeros[i] = numero;
                            break; // Sai do loop.
                        }
                        // Exibe uma mensagem de erro se a entrada for inválida.
                        Console.WriteLine("Por favor, insira um número inteiro positivo maior que zero.");
                    }
                }

                // Exibe os números escolhidos pelo usuário.
                Console.WriteLine("\nOs números escolhidos são: " + string.Join(", ", numeros));
                // Exibe o valor de X informado pelo usuário.
                Console.WriteLine($"O número X é: {valor_X}");

                // Declara variáveis para contar os números maiores, menores e iguais a X.
                int maiores = 0, menores = 0, iguais = 0;

                /* Um loop para verificar a relação de cada número do vetor com o valor de X.
                foreach (int numero in numeros)*/
                //O foreach pega cada elemento do vetor numeros(um por vez) e o armazena na variável numero.
                /*Assim, você pode trabalhar diretamente com o valor do elemento atual sem precisar de um índice. int numero:*/
                /*A variável numero é declarada dentro do foreach e representa o valor atual do vetor que está sendo processado in numeros: */
                //Significa que o foreach está iterando sobre todos os elementos do vetor numeros.
                /* Bloco de código dentro do foreach:
                Para cada elemento do vetor, o programa verifica:
                Se o número é maior que valor_X, incrementa o contador maiores.
                Se o número é menor que valor_X, incrementa o contador menores.
                Caso contrário(o número é igual a valor_X), incrementa o contador iguais.*/
                foreach (int numero in numeros)
                {
                    if (numero > valor_X)
                    {
                        // Se o número for maior que X, incrementa o contador 'maiores'.
                        maiores++;
                    }
                    else if (numero < valor_X)
                    {
                        // Se o número for menor que X, incrementa o contador 'menores'.
                        menores++;
                    }
                    else
                    {
                        // Se o número for igual a X, incrementa o contador 'iguais'.
                        iguais++;
                    }
                }

                // Exibe os resultados da análise.
                Console.WriteLine($"\nResultados:");
                Console.WriteLine($"- Quantidade de números maiores que {valor_X}: {maiores}");
                Console.WriteLine($"- Quantidade de números menores que {valor_X}: {menores}");
                Console.WriteLine($"- Quantidade de números iguais a {valor_X}: {iguais}");
            } while (ContinuarOuSair());
        }
        static bool ContinuarOuSair()
        {
            Console.Write("Deseja continuar (S) Sim ou (N) Não? ");

            while (true)
            {
                string resposta = Console.ReadLine().Trim().ToUpper();

                if (string.IsNullOrEmpty(resposta) || string.IsNullOrWhiteSpace(resposta) || (resposta != "S") && (resposta != "N"))
                {
                    Console.Write("Erro: Opção inválida! Digite (S) para Sim ou (N) para Não. ");
                    continue;

                }
                if (resposta == "N")
                {
                    Console.WriteLine("Saindo do programa...");
                    Console.WriteLine("Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    return false;
                }
                return true;

            }                      
        }
    }
}
            
        


    


