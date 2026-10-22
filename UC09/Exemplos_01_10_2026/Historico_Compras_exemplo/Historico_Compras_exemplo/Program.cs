using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico_Compras_exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] compras = new double[10, 5];
            for (int i = 0; i < 10; i++)
            {
                double total = 0;
                Console.WriteLine($"\n Compras do Cliente {i+1}");
                for (int j = 0; j < 5; j++)
                {

                    Console.WriteLine($"Valor da compra{j + 1}: R$ ");
                    compras[i,j]=double.Parse( Console.ReadLine() );
                    total+= compras[i,j];
                
                }
                Console.WriteLine($"Total gasto pelo cliente {i + 1}: R$ {total:0.00}");
            }
        }
    }
}
