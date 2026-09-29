using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Impar_Array
{
    internal class Program
    {
        // Crie um programa que armazene 20 numeros e separe-os em dois arrays: um com números pares e outro com números ímpares.
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int[] par = new int[20];
            int[] impar = new int[20];   
            int qtd_impar=0, qtd_par=0;



            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º Numero: ");
                numeros[i]=int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    par[qtd_par] = numeros[i];
                    qtd_par++;
                }
                else
                {
                    impar[qtd_impar] = numeros[i];
                    qtd_impar++;
                }

            }


            Console.WriteLine("Quantidade de Pares:"+qtd_par);
            Console.WriteLine("Quantidade de Impares:" + qtd_impar);

            Console.WriteLine("Numeros pares");
            for (int i = 0; i < qtd_par; i++)
            {
                Console.Write(par[i]+" ");   
            }



            Console.WriteLine("\nNumeros impares");
            for (int i = 0; i < qtd_impar; i++)
            {
                Console.Write(impar[i]+" ");
            }

            


        }
    }
}
