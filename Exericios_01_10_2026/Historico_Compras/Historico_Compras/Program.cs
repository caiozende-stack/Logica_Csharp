using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico_Compras
{
    internal class Program
    {
        //Desenvolva um programa que armazene o historico de compras de 10 clientes e mostre o total gasto por cada cliente.
        static void Main(string[] args)
        {
            double[] total_gasto= new double[10];
            double lucro=0;

            for(int i = 0; i < total_gasto.Length; i++)
            {

                Console.WriteLine("Digite quanto o "+ (i+1)+" º Cliente Gastou");
                total_gasto[i] = double.Parse(Console.ReadLine());

            }


            for(int i = 0 ; i < 10 ; i++)
            {
                lucro = lucro + total_gasto[i];
            }

            Console.WriteLine("Lucro foi de "+lucro);
            

        }


    }
}
