using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie um algoritmo para o cadastro de produto: Codigo, Fabricante, categoria, Preço, Estoque, Valor total em estoque
             */
            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;

            Console.WriteLine("Digite o código:");
            codigo=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Fabricante:");
            fabricante=Console.ReadLine();

            Console.WriteLine("Digite a categoria:");
            categoria=Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            preco=double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o estoque:");
            estoque=int.Parse(Console.ReadLine());

            total = preco * estoque;

            Console.WriteLine("O valor total em estoque é"+total);
        }
    }
}
