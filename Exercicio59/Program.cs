using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
         * Este programa solicita ao usuário duas letras de A a Z e calcula o número de caracteres entre elas.
         * Ele assume que as letras são digitadas em ordem alfabética. Se não forem, exibe uma mensagem de erro.
         */

            while (true) // Loop para garantir que o usuário insira os dados corretamente
            {
                char[] _letra = new char[2]; // Vetor para armazenar as duas letras digitadas
                char letra; // Variável auxiliar para armazenar temporariamente a entrada do usuário

                Console.WriteLine("\nInforme 2 letras: "); // Mensagem para o usuário

                // Loop para coletar as duas letras
                for (int i = 0; i < 2; i++)
                {
                    while (true) // Loop para validar a entrada do usuário
                    {
                        string input = Console.ReadLine().ToUpper(); // Lê a entrada do usuário e converte para maiúscula

                        // Verifica se a entrada é válida (não vazia e contém apenas um caractere)
                        if (string.IsNullOrEmpty(input) || !char.TryParse(input, out letra))
                        {
                            Console.WriteLine("\nErro: letra não identificada, por favor tente novamente.");
                            continue; // Repete a solicitação caso a entrada seja inválida
                        }

                        _letra[i] = letra; // Armazena a letra válida no vetor
                        break; // Sai do loop de validação
                    }
                }

                int codigo1 = (int)_letra[0]; // Converte a primeira letra para seu valor ASCII
                int codigo2 = (int)_letra[1]; // Converte a segunda letra para seu valor ASCII

                // Verifica se as letras estão em ordem alfabética
                if (codigo1 > codigo2)
                {
                    Console.WriteLine("\nErro: As letras precisam estar em ordem alfabética, informe novamente..");
                    continue; // Retorna ao início do loop principal para solicitar novos valores
                }

                // Calcula e exibe a quantidade de caracteres entre as letras
                Console.WriteLine($"\nO número de caracteres entre '{_letra[0]}' e '{_letra[1]}' é: {codigo2 - codigo1 - 1}");

                break; // Sai do loop principal, pois a entrada foi válida e o cálculo foi feito
            }

            Console.ReadLine(); // Mantém o console aberto até o usuário pressionar Enter
        }
    }
}
