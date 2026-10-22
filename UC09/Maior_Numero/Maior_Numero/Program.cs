using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double maior=0,numero;
            Console.WriteLine("Informe 5 numeros e direi qual deles é maior");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Numero" + (i+1) + ":");

                numero=double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = numero;
                }else if (numero > maior)
                {
                    maior = numero;
                }
            }
            Console.WriteLine("O maior numero é " + maior);
        }
    }
}
