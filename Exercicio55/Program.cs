using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco.
            Imprimir também a quantidade de espaços em branco da frase.*/

            string frase;

            do
            {
                Console.WriteLine("\nInsira uma frase de até 50 caracteres: ");
                frase = Console.ReadLine();

                if (frase.Length > 50)
                {
                    Console.WriteLine("Erro: a frase deve conter apenas 50 caracteres");
                }

            } while (frase.Length > 50);

            int contaEspaçosEmBranco = frase.Count(char.IsWhiteSpace); // Conta os espaços em branco    

            string fraseSemEspaco = new string(frase.Where(c => !char.IsWhiteSpace(c)).ToArray());
            /* Remove espaços em brancoEsse comando em C# remove todos os espaços em branco de uma string usando LINQ. Vamos quebrá-lo em partes para entender melhor:
               1.frase.Where(c => !char.IsWhiteSpace(c))
                .frase é uma string original contendo espaços.
                .Where(c => !char.IsWhiteSpace(c)) filtra a string, mantendo apenas os caracteres que não são espaços em branco.
                . char.IsWhiteSpace(c) verifica se o caractere c é um espaço em branco.
                .O operador !(negação)inverte a lógica, ou seja, mantém apenas os caracteres que não são espaços.

               2. .ToArray()
                .O método .ToArray() converte o resultado da filtragem(Where) em um array de caracteres(char[]).
               3. new string(...)
                .Como ToArray() retorna um char[], usamos new string(...) para transformar esse array de volta em uma string.*/

            Console.WriteLine($"{fraseSemEspaco}");

            Console.WriteLine($"\nA quantidade de espaços em branco é: {contaEspaçosEmBranco} e a frase sem espaço é {fraseSemEspaco}");

            Console.WriteLine("Encerrando programa...");
            Console.ReadKey();

        }
    }
}

