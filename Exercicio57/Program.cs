using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia uma frase e imprima somente as vogais*/

            string frase;

                Console.WriteLine("\nInsira uma frase: ");

                frase = Console.ReadLine();
                
            string vogais  = new string(frase.Where(n => "aeiouAEIOU".Contains(n)).ToArray());

            Console.WriteLine($"\nVogais na frase: {vogais}");

            Console.ReadLine();

            
        }
    }
}
