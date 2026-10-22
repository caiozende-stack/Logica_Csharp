using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             5-	Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição 
                de acordo com a tabela abaixo:
                Fórmula do IMC = peso / (altura) ²
                Tabela Condições IMC
  
                 Abaixo de 18,5   | Abaixo do peso          
                 Entre 18,6 e 24,9 | Peso ideal (parabéns)  
                 Entre 25,0 e 29,9 | Levemente acima do peso
                 Entre 30,0 e 34,9 | Obesidade grau I 
                 Entre 35,0 e 39,9 | Obesidade grau II (severa)
                 Maior ou igual a 40 | Obesidade grau III (mórbida)

             */


            double altura, peso, imc;
            Console.WriteLine("   Tabela condições IMC");
            Console.WriteLine(
                "Abaixo de 18,5      | Abaixo do peso\n" +
                "Entre 18,6 e 24,9   | Peso ideal (parabéns)\n" +
                "Entre 25,0 e 29,9   | Levemente acima do peso\n" +
                "Entre 30,0 e 34,9   | Obesidade grau I \n" +
                "Entre 35,0 e 39,9   | Obesidade grau II (severa)\n" +
                "Maior ou igual a 40 | Obesidade grau III (mórbida)\n\n");
            Console.WriteLine("Informe sua altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu peso");
            peso = double.Parse(Console.ReadLine());

            imc=peso/(altura*altura);

            Console.WriteLine($"O seu IMC é {imc}");

            if (imc >= 40)
            {
                Console.WriteLine("Maior ou igual a 40 | Obesidade grau III (mórbida)");
            }else if(imc>=35)
            {
                Console.WriteLine("Entre 35,0 e 39,9 | Obesidade grau II (severa)");
            }
            else if(imc>=30 )
            {
                Console.WriteLine("Entre 30,0 e 34,9 | Obesidade grau I ");
            }
            else if(imc>=25)
            {
                Console.WriteLine("Entre 25,0 e 29,9 | Levemente acima do peso");
            }
            else if(imc>=18.5)
            {
                Console.WriteLine(" Entre 18,6 e 24,9 | Peso ideal (parabéns)  ");
            }
            else
            {
                Console.WriteLine("Abaixo de 18,5   | Abaixo do peso");
            }

           

        }
    }
}
