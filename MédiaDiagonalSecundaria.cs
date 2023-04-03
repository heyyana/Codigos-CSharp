// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"); 

using System;
namespace primeiro_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            int l, c, soma = 0;
            Console.WriteLine("Insira 9 valores para a matriz:");
            for (l = 0; l < 3; l++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.WriteLine("Informe o valor do indice " + l + " , " + c);
                    mat[l, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
            for (l = 0; l < 3; l++)
            {
                for (c = 0; c < 3; c++)
                {
                    if (l<c)
                    {
                        Console.WriteLine(" Acima da matriz secundária  : " + mat[l,c]);
                    }
                    if (l>c)
                    {
                        Console.WriteLine(" Abaixo da matriz secundária  : " + mat[l, c]);
                    }
                }
                
            }
        }
    }
}
