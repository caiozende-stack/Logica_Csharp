using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um numero: ");
            n1=int.Parse(Console.ReadLine());
            if (n1 > 100)
            {
                Console.WriteLine("Seu numero: " + n1 + " e ele é maior que 100");
            }
            else
            {
                Console.WriteLine("Seu numero: " + n1 + " e ele não é maior que 100");
            }


        }
    }
}
