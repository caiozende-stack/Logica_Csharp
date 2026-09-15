using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Desconto_Loja
{
    internal class Program
    {
        static void CalcularDesconto(double valor)
        {
            if (valor > 100)
            {
                Console.WriteLine($"O desconto desse produto vai ser de 10%, entao voce esta recebendo {valor * 0.10:F2} reais de desconto");
            }
            else
            {
                Console.WriteLine($"O desconto desse produto vai ser de 5%, entao voce esta recebendo {valor * 0.05:F2} reais de desconto");
            }
        }

        static void Main(string[] args)
        {

            /*
             5-Calcular desconto
            Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário, o desconto é de 5%.
            Dado o Preço, calcule o valor do desconto
            .Entrada:120
            .Saida esperada:12 reais de desconto 
             */

            double valor;
            Console.WriteLine("Insira o valor e descubra o desconto que irá receber no produto:");
            valor=double.Parse(Console.ReadLine());
            CalcularDesconto(valor);

            /*
            if (valor > 100)
            {
                Console.WriteLine($"O desconto desse produto vai ser de 10%, entao voce esta recebendo {valor*0.10:F2} reais de desconto");
            }
            else
            {
                Console.WriteLine($"O desconto desse produto vai ser de 5%, entao voce esta recebendo {valor * 0.05:F2} reais de desconto");
            }

            */

        }
    }
}
