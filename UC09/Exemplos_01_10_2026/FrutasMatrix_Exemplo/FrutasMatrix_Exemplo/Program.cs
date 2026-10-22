using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasMatrix_Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] frutas = new int[5, 3];
            string[] tipos = { "Maçã", "Banana", "Laranja","Uva", "Pera" };

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"\n {tipos[i]}:");
                for(int j= 0; j < 3; j++)
                {
                    Console.Write($"Cesta{j + 1}:");
                    frutas[i,j]=int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine("\n Total de cada fruta");
            for(int i = 0;i < 5; i++)
            {
                int total = frutas[i, 0] + frutas[i, 1] + frutas[i, 2];
                Console.WriteLine($"{tipos[i]}:{total}");
            }




        }
    }
}
