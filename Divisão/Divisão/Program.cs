using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Digite seu numero");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu segundo numero: ");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("A divisão do numero é igual à: "+n1/n2);
        }
    }
}
