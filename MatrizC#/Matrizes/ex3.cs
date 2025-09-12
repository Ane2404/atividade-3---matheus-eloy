using System;
using Biblioteca;

class ex3
{
    static int ocorrencia (int [,] matriz, int Xzin)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int ocorrencia = 0;

        for ( int i = 0; i < linhas; i++)
        {
            for ( int j = 0; j < cols; j++)
            {
              if (matriz[i, j] == Xzin)
              {
                ocorrencia++;
              }
            }
        }


        return ocorrencia;
    }
    static void Main()
    {
        int linhas, cols, Xzin;
        Console.WriteLine("entre com a quantidade de linhas e colunas: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("informe o valor de X: ");
        Xzin = int.Parse(Console.ReadLine());
        int[,] matriz = new int[ linhas, cols];
        biblioteca.gerarM(matriz);
        biblioteca.mostrarM(matriz);

        Console.WriteLine("ocorrencias: " + ocorrencia(matriz, Xzin));
    }

}