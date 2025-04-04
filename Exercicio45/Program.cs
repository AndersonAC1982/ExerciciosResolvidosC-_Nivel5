using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que digite a quantidade de números que ele quer inserir no vetor.
        // O Console.Write é usado para mostrar uma mensagem no console.
        Console.Write("Digite a quantidade de números: ");

            // O Console.ReadLine lê o que o usuário digitar no console. 
            // O valor retornado é uma string, então usamos int.Parse para converter para inteiro.
            int n = int.Parse(Console.ReadLine());

            // Aqui estamos criando um vetor de inteiros chamado 'numeros' para armazenar os números.
            // O tamanho do vetor será igual ao valor de 'n', ou seja, a quantidade de números informada pelo usuário.
            int[] numeros = new int[n];

            // Exibe uma mensagem para informar ao usuário que ele pode começar a digitar os números.
            Console.WriteLine("Digite os números:");

            // O laço 'for' abaixo vai repetir 'n' vezes para ler cada número que o usuário informar.
            // A variável 'i' começa em 0, e o laço continua até que 'i' seja menor que 'n'.
            // A cada repetição, 'i' vai sendo incrementado (i++).
            for (int i = 0; i < n; i++)
            {
                // Lê cada número informado pelo usuário e armazena na posição 'i' do vetor 'numeros'.
                // O número é lido como uma string e convertido para inteiro com int.Parse.
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Exibe a mensagem que agora vamos mostrar os números na ordem inversa.
            Console.WriteLine("Números na ordem inversa:");

            // O laço 'for' abaixo vai imprimir os números na ordem inversa.
            // Começamos de 'n - 1' (último índice do vetor) e vamos até 0, com 'i--' (decremento de 'i').
            for (int i = n - 1; i >= 0; i--)
            {
                // A cada repetição do laço, imprimimos o número armazenado no índice 'i' do vetor 'numeros'.
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("Pressione qualquer tecla...");
            Console.ReadKey();
        }
    }
}
