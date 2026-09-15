using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ano bissexto
            Determine se um ano é bissexto se for divisível por 4, mas não por 100, a não ser que seja divisível por 400.
            .Entrada: 2024
            .Saída esperada ano bissexto
             */

            int ano;
            Console.WriteLine("Diga o ano e descubra se é bissexto");
            ano=int.Parse(Console.ReadLine());

            if((ano%4==0 && ano % 100 != 0) || ano%400==0) {

                Console.WriteLine($"{ano} é um ano bissexto");

            }
            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto");
            }

           
        }
    }
}
