using System;
using System.Globalization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array pt1
            /*
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i=0; i < n; ++i)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < n; ++i)
            {
                soma += vetor[i];
            }

            Console.WriteLine(soma/n);
            */
            #endregion

            #region Array pt2

            /*
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];  


            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                Produto p = new Produto { Descricao = nome, Preco = preco };
                vetor[i] = p;
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine(media);
            */

            #endregion

            #region Exercicio fixação

            /*
            Quarto[] quartos = new Quarto[10];

            Console.WriteLine("\nQuartos que serão alocados: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                // limpa tela a cada loop
                Console.WriteLine("\nNome do locador: ");
                string nome = Console.ReadLine();
                Console.WriteLine("\nEmail: ");
                string email = Console.ReadLine();

                Pessoa p = new Pessoa(nome,email);

                // cria o quarto
                Quarto q = new Quarto(p);

                // numero do quarto
                Console.WriteLine("\nQuarto a ser alocado: ");

                // aloca o quarto
                quartos[int.Parse(Console.ReadLine())] = q;
                Console.Clear();
            }

            Console.WriteLine("\nQuartos alocados: ");

            for(int i=0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine("\n" + i + " : " + quartos[i].ToString());
                }
            }
            */

            #endregion

        }
    }
}
