using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucessor_Antecessor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, sucessor, antecessor;
            Console.WriteLine("Escolha um numero:");
            num1=int.Parse(Console.ReadLine());
            sucessor = num1 + 1;
            antecessor= num1 - 1;
            Console.Write("O antecessor é "+antecessor);
            Console.Write(" , o sucessor é " + sucessor);

        }
    }
}
