using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Adivinhação
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10;
                o jogador 2 insere números na tentativa de acertar o número escolhido pelo jogador 1.
            Quando ele acertar, o algoritmo deve informar que ele acertou o número X (escolhido pelo jogador 1) em X tentativas (quantidade de tentativas do jogador 2).
             */

            int numeroJ1, numeroJ2, tentativas = 0;
            Random rand = new Random();
           
            List<int> sorteados = new List<int>();

            //Console.WriteLine("Jogador 1 escolha um numero de 1 a 10");

            //numeroJ1= int.Parse(Console.ReadLine());

            numeroJ1 = rand.Next(1,11);
            Console.Clear();
            Console.WriteLine($"jogador numero escolhido pelo jogador 1 : {numeroJ1}");
            Console.WriteLine("Jogador 2 tente adivinhar o numero escolhido pelo jogador 1");
        
            do
            {

                
                if (tentativas>=1)
                {
                    Console.WriteLine("Tente denovo:");
                    // numeroJ2 = int.Parse(Console.ReadLine());
                    // tentativas++;
                    numeroJ2 = Sortear();
                    Console.WriteLine($"jogador numero escolhido pelo jogador 2: {numeroJ2}");
                    tentativas++;
                }
                else
                {
                    //numeroJ2 = int.Parse(Console.ReadLine());
                    // tentativas++;
                    numeroJ2 = Sortear();
                    Console.WriteLine($"jogador numero escolhido pelo jogador 2 : {numeroJ2}");
                    tentativas++;

                }

             
            } while (numeroJ1 != numeroJ2);

            Console.WriteLine("Parabens voce conseguiu, voce acertou o número");
            Console.WriteLine($"O numero escolhido era {numeroJ1} e voce conseguiu em {tentativas} tentativas");


            int Sortear()
            {
                int numero;

                do
                {
                    numero = rand.Next(1, 11);
                }
                while (sorteados.Contains(numero));

                sorteados.Add(numero);

                return numero;
            }



        }
    }
}
