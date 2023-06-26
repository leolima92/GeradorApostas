using System;

namespace GeradorApostas
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 6; 
            int minNumero = 1; 
            int maxNumero = 60; 

            int[] numerosAposta = GerarAposta(quantidadeNumeros, minNumero, maxNumero);

            Console.WriteLine("Números da Aposta:");
            for (int i = 0; i < numerosAposta.Length; i++)
            {
                Console.Write(numerosAposta[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        static int[] GerarAposta(int quantidadeNumeros, int minNumero, int maxNumero)
        {
            int[] numerosAposta = new int[quantidadeNumeros];
            Random random = new Random();

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                int numero;

                do
                {
                    numero = random.Next(minNumero, maxNumero + 1);
                } while (Array.IndexOf(numerosAposta, numero) != -1);

                numerosAposta[i] = numero;
            }

            Array.Sort(numerosAposta);

            return numerosAposta;
        }
    }
}
