using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_Vinhos
{
    internal class Program
    {
        static int vinhot = 0, vinhob = 0;
        static void EscolhaContador(string escolha)
        {
            if (escolha == "t")
            {
                vinhot++;
            }
            if (escolha == "b")
            {
                vinhob++;
            }

        }


        static void Main(string[] args)
        {
            /*
             Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada tipos de vinho: 
            sendo "t" para vinho tinto
            sendo "b" para vinho branco
            Como a quantidade de vinhos é desconhecida, utilize a letra "f" para finalizar.Após finalizar o programa deve mostrar a quantidade de cada vinho na adega.
             */

            //int vinhot=0, vinhob=0;
            string escolha;

            do
            {
        
                Console.Clear();
                if (vinhot > 0 || vinhob > 0)
                {
                    Console.WriteLine($"O estoque tem {vinhot} vinhos tintos e {vinhob} vinhos brancos ");
                }

                Console.WriteLine("Informe qual o tipo do vinho voce quer cadastrar ");
                Console.WriteLine("t- para vinho tinto ");
                Console.WriteLine("b- para vinho branco ");
                Console.WriteLine("f- para finalizar o programa");

              
                escolha = Console.ReadLine();
                EscolhaContador(escolha);
               
                

            } while (escolha != "f");

            Console.Clear();
            Console.WriteLine($"O estoque tem {vinhot} vinhos tintos e {vinhob} vinhos brancos ");



        }
    }
}
