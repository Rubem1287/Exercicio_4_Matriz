using System;

namespace Exercício_4_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros;

            int n = int.Parse(Console.ReadLine());

            numeros = new int[n, n];
            int soma = 0;


            for(int l = 0;l<n;l++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for(int c=0;c<n;c++)
                {
                    numeros[l, c] = int.Parse(vetor[c]);
                }
            }

            for(int l=0;l<n;l++)
            {
                soma = soma + numeros[l, l];
            }

            Console.WriteLine(soma);
        }
    }
}
