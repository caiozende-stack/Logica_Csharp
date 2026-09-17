using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia.
            Um funcionário controla a qualidade,cadastrando o numero da peça e o seu estado ( aprovado ou reprovado). 
            Criar um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia
             */

            int aprovadas = 0;
            int reprovadas = 0;
            Random random = new Random();
            string estado;

            for (int i = 1; i <= 400; i++)
            {
                Console.WriteLine($"Peça {i}");
                Console.Write("Digite o número da peça: ");
                //int numero = int.Parse(Console.ReadLine());

                Console.Write("Digite o estado (A = Aprovada / R = Reprovada) e F para finalizar: ");
                 estado = Console.ReadLine().ToUpper();
                //estado = random.Next(1, 101) <= random.Next(1, 100)?"A":"R";

                if (estado == "F")
                {
                    break;
                }

                if (estado == "A")
                {
                    aprovadas++;
                }
                else if (estado == "R")
                {
                    reprovadas++;
                }
                else
                {
                    Console.WriteLine("Estado inválido!");
                    i--;
                }

                Console.WriteLine();
            }

            Console.WriteLine("===== RESULTADO DO DIA =====");
            Console.WriteLine($"Total de peças aprovadas: {aprovadas}");
            Console.WriteLine($"Total de peças reprovadas: {reprovadas}");




        }
    }
}
