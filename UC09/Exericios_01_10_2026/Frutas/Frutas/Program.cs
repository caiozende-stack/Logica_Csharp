using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{
    internal class Program
    {
        //Implemente um sistema que armazene as quantidades de 5 tipos de frutas em 3 cestas e calcule o total de frutas de cada tipo.

        static void Main(string[] args)
        {
            string[] nomesfrutas = { "Maça","Melancia","Abacaxi","Uva","Pera" };
            
            int[] cesta1 = new int[5];
            int[] cesta2 = new int[5];
            int[] cesta3 = new int[5];


            Console.WriteLine("Cesta 1\n");
            for(int i = 0; i < cesta1.Length; i++) {

                Console.WriteLine("digite a quantidade de " + nomesfrutas[i]);
                cesta1[i] = int.Parse(Console.ReadLine());

                }

            Console.WriteLine("Cesta 2\n");
            for (int i = 0; i < cesta2.Length; i++)
            {
                Console.WriteLine("digite a quantidade de " + nomesfrutas[i] );
                cesta2[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Cesta 3\n");
            for (int i = 0; i < cesta3.Length; i++)
            {
                Console.WriteLine("digite a quantidade de " + nomesfrutas[i]);
                cesta3[i] = int.Parse(Console.ReadLine());

            }


            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("No total foi comprado " + (cesta1[i] + cesta2[i] + cesta3[i])+" "+ nomesfrutas[i]);

            }

        }
    }
}
