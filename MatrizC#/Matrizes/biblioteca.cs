using System;

namespace Biblioteca
{
    class biblioteca
    {
        public static void lerM (int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("entre com os dados da matriz: ");
            for (int i=0 ; i < linhas ; i++)
            {
                for (int j = 0; j< cols; j++)
                {
                    Console.WriteLine($"[{i}, {j}]:");
                    matriz[i, j]= int.Parse(Console.ReadLine());
                }//fim do for J
            }//fim for I
        }

        public static void gerarM (int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Random rand = new Random(); //gerador aleatório
            Console.WriteLine("gerando matriz:... ");
             for (int i=0 ; i < linhas ; i++)
            {
                for (int j = 0; j< cols; j++)
                {
                    matriz[i, j] = rand.Next(100);
                }//fim do for J
            }//fim for I
        }

        public static void mostrarM (int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("***MATRIZ*** ");
             for (int i=0 ; i < linhas ; i++)
            {
                for (int j = 0; j< cols; j++)
                {
                    Console.WriteLine(matriz[i, j] + " | ");
                }//fim do for J
                Console.WriteLine();
            }//fim for I
        }
    }
}