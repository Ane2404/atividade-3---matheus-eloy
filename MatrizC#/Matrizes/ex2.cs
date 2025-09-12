using System;
using Biblioteca;

class ex2
{
    static int getMax(int [,] matriz)
    {
        //aqui vamos percorrer a matriz e retornar o maior valor
        int maior = matriz [0,0];
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for ( int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
              if (matriz[i, j] < maior)
              maior = matriz[i, j];
        }


        return maior;
    }
    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("entre com a quantidade de linhas e colunas: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        //até aqui, pedimos que o usuário defini-se o valor das nossas linhas e colunas.
        int[,] matriz = new int[ linhas, cols];
        // int [,] significa que temos uma matriz com mais de uma dimensão, a ',' irá separa-las. Depois definimos que o tamanho da matriz será o tamanho das linhas e das colunas.
        biblioteca.gerarM(matriz);
        biblioteca.mostrarM(matriz);
        Console.WriteLine("maior valor: " + getMax(matriz));
    }
}