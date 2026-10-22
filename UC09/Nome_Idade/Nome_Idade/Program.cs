using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Digite uma mensagem na tela pedindo nome completo , depois peça sua idade 

            cadeia nome
            inteiro idade
            escreva(" Digite seu nome: ")
            leia(nome)
            escreva(" digite sua idade ")
            leia(idade)
            escreva(" Parabens " + nome + " você acabou de ganhar uma coca-cola")
            escreva("\nvocê possui " + idade + " anos, beba mais agua")
             */

            string nome;
            int idade;
            //double salario;
            Console.WriteLine("Digite seu nome");
            nome=Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Parabens"+nome+"acabou de ganhar uma coca-cola");
            Console.WriteLine($"Voce possui {idade} anos,beba mais agua");
           
        }
    }
}
