using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.
             */
            double valor;
            Console.WriteLine("Digite um valor");
             valor=double.Parse(Console.ReadLine());
            Console.WriteLine($"O valor com reajuste de 5% é {(valor+(valor*0.05)):F2} ");

        }
    }
}
