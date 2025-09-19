using System ;
using Biblioteca;

class ex8 
{
    static int RmesmoL (int[,] mapa)
    {
        int cont=0;
        int linhas = mapa.GetLength(0);
        int colunas = mapa.GetLength(1);
        for ( int i = 0; i < linhas; i++)
        {
            for ( int j = 0; j < colunas; j++)
            {
              if (mapa[i, j] > 1)
              {
                cont++;
              }
            }
        }

        //vamos percorrer a matriz e se nossa função achar um numero maior que um, encrementamos o contador.
        return cont;
    }
    static void Main ()
    {
        //de inicio, vamos desenvolver nossa matriz e receber várias coordenadas.
        int x, y, qntR;
        int linhas, colunas;
        Console.WriteLine("Qual a quantidade de linhas e colunas da nossa matriz? ");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int [,] mapa = new int[linhas, colunas];
        Console.Write("Quantos raios foram anotados? ");
        qntR = int.Parse(Console.ReadLine());

        for (int i = 0; i< qntR; i++)
        {
            Console.Write("coordenadas que o raio caiu: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x,y]++;

        }
        biblioteca.mostrarM(mapa);
        //aqui vamos printar nossa função na tela
        Console.WriteLine($"Quantidade de vezes que um raio caiu no mesmo lugar: [{RmesmoL(mapa)}]");


    }
}