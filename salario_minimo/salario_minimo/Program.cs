using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, 
            calcule quantos salários mínimos esse 
            usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).
             */
            double salario_min, salario,qtd_salarios;

            Console.WriteLine("Qual o sálario minimo?");
            salario_min = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu sálario?");
            salario= double.Parse(Console.ReadLine());

            qtd_salarios = salario / salario_min;

            Console.WriteLine($"O seu salario equivale a {qtd_salarios} salarios minimos");

        }
    }
}
