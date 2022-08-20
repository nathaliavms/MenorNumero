using System;

namespace MenorePosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quantos números vai inserir?");
            var quantidade = int.Parse(Console.ReadLine());
            string[] separar = Console.ReadLine().Split(' ');
           
            int[] vetor = new int[quantidade];
            var menorNumero = vetor[0];
            var posicao = 0;

            for (int i = 0; i < quantidade; i++)
                vetor[i] = int.Parse(separar[i]);

            for (int i = 0; i < quantidade; i++)
            {
                if (vetor[i] < menorNumero)
                {
                    menorNumero = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Menor valor: " + menorNumero);
            Console.WriteLine();
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}
