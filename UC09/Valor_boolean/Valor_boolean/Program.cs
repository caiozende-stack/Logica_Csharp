using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.
             */
            bool valor1, valor2;

            Console.Write("Digite o primeiro valor (true ou false): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (true ou false): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == true && valor2 == true)
            {
                Console.WriteLine("Ambos Verdadeiros");
            }
            else if (valor1 == false && valor2 == false) {

                Console.WriteLine("Ambos Falsos");

            }
            else
            {
                Console.WriteLine("Valores diferentes");
            }


        }
    }
}
