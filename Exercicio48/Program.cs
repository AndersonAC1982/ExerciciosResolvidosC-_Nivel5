using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop principal para repetir o programa caso o usuário deseje
            do
            {
                Console.Clear(); // Limpa o console para deixar a interface limpa a cada execução

                // Declaração dos vetores para armazenar os nomes e idades das candidatas
                string[] nomes = new string[20]; // Vetor para os nomes das candidatas
                int[] idades = new int[20];      // Vetor para as idades das candidatas

                Console.WriteLine("Insira os nomes e idades das candidatas:");

                // Laço para capturar as informações de 20 candidatas
                for (int i = 0; i < 20; i++)
                {
                    // Entrada e validação do nome
                    while (true)
                    {
                        Console.Write($"\nCandidata {i + 1} - Nome: ");
                        string nome = Console.ReadLine(); // Lê o nome inserido pelo usuário

                        // Verifica se o nome não está vazio ou composto apenas por espaços
                        if (!string.IsNullOrWhiteSpace(nome))
                        {
                            nomes[i] = nome; // Armazena o nome no vetor
                            break; // Sai do loop de validação do nome
                        }

                        Console.WriteLine("Erro: Nome inválido! Insira um nome válido."); // Mensagem de erro caso o nome seja inválido
                    }

                    // Entrada e validação da idade
                    while (true)
                    {
                        Console.Write($"Candidata {i + 1} - Idade: ");

                        // Tenta converter a entrada para um número inteiro e verifica se é maior que zero
                        if (int.TryParse(Console.ReadLine(), out int idade) && idade > 0)
                        {
                            idades[i] = idade; // Armazena a idade no vetor
                            break; // Sai do loop de validação da idade
                        }

                        Console.WriteLine("Erro: Idade inválida! Insira uma idade válida."); // Mensagem de erro caso a idade seja inválida
                    }
                }

                // Exibição das candidatas aptas
                Console.WriteLine("\nCandidatas aptas para a campanha publicitária:");
                bool encontrouAptas = false; // Variável para verificar se existe ao menos uma candidata apta

                // Laço para percorrer as candidatas e verificar se estão aptas
                for (int i = 0; i < 20; i++)
                {
                    // Verifica se a idade da candidata está entre 18 e 20 anos (inclusive)
                    if (idades[i] >= 18 && idades[i] <= 20)
                    {
                        Console.WriteLine($"- {nomes[i]} (Idade: {idades[i]})"); // Exibe o nome e a idade da candidata apta
                        encontrouAptas = true; // Marca que ao menos uma candidata apta foi encontrada
                    }
                }

                // Caso nenhuma candidata apta seja encontrada
                if (!encontrouAptas)
                {
                    Console.WriteLine("Nenhuma candidata apta foi encontrada.");
                }

                // Pergunta se o usuário deseja repetir o programa
                Console.WriteLine("\nDeseja reiniciar o programa? (S/N)");
                string resposta = Console.ReadLine().Trim().ToUpper(); // Lê a resposta, remove espaços e converte para maiúsculas

                // Encerra o programa caso a resposta não seja "S"
                if (resposta != "S")
                {
                    break; // Sai do loop principal
                }
            } while (true);

            Console.WriteLine("Programa encerrado.");

        }
    }
}
