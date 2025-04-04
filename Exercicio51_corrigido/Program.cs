using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio51_corrigido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] _nota = new double[4];
            int count_aluno = 0;
            int count_aluno2 = 0;

            while (true)
            {
                Console.WriteLine("Insira o nome do aluno: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("\nErro: Insira um nome válido");
                    continue;
                }

                List<double> notas = new List<double>();
                Console.WriteLine($"\nInsira as 4 notas do aluno {nome}");

                for (int i = 0; i < 4; i++)
                {
                    while (true)
                    {
                        Console.Write($"Nota_{i + 1} =  ");
                        string input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("\nErro: Informe uma nota entre 0.0 a 10.0");
                            continue;
                        }

                        if (!double.TryParse(input, out double nota) || nota < 0.0 || nota > 10.0)
                        {
                            Console.WriteLine("\nErro: Informe uma nota de 0.00 a 10.0");
                            continue;
                        }

                        notas.Add(nota);
                        break;
                    }
                }

                double media = notas.Average();
                Console.WriteLine($"\nA média de {nome} é {media:f1}");

                if (media > 7.0)
                {
                    count_aluno++;
                }
                if (media < 5.0)
                {
                    count_aluno2++;
                }

                // Adicionada a opção para o usuário decidir se deseja continuar inserindo alunos
                Console.Write("\nDeseja inserir outro aluno? (s/n): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "s") // Se a resposta não for 's', o loop é interrompido
                {
                    break;
                }
            }

            // As mensagens finais agora são exibidas apenas após o usuário decidir parar
            Console.WriteLine($"\n{count_aluno} aluno(s) está(ão) com a nota acima de 7.0");

            if (count_aluno2 > 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.0");
            }

            Console.WriteLine("\nEncerrando o programa...");
            Console.ReadKey();
        }
    }
}
