using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.Tracing;

namespace Subtracao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number, number2, res;
            Console.WriteLine("Digite o primeiro numero:");
            number=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            number2 = int.Parse(Console.ReadLine());
            res = number - number2;
            Console.WriteLine("O resultado da subtração é " + res);

        }
    }
}
