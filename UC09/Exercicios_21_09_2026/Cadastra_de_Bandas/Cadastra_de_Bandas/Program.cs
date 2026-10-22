using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cadastra_de_Bandas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             se  /  enquanto/  para /  caso
             if     while  /   for /   switch

             Crie um sistema de cadastro de Álbuns de um artista/ banda em que será possível cadastrar um numero X de músicas informada pelo usuário.
             Crie um menu de opções para isso
             */
            int opcao = 0;

            while (opcao != 4)
            {

                Console.Clear();// limpa a tela
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░" + "\n\n");


                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1- Cadastrar álbum da banda\n" +
                                  "2- Cadastrar álbum do artista\n" +  // Nome do artista, Ano , qtd_album, qtd vendas
                                  "3- Cadastrar músicas\n" + //digitar a quantidade de musicas que vai ser cadastradas Nome da musica, Duração, premiação
                                  "4- Sair do Programa");
                Console.WriteLine("----->");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Cadastro_Bandas();
                        break;
                    case 2:
                        Cadastro_Artista();
                        break;
                    case 3:
                        Cadastro_Musica();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa !!! Tchau Tchau!!   :)  ");
                        break;

                    default:
                        break;
                }

            }

            Thread.Sleep(2000);
            Environment.Exit(0);
        }

       static void Cadastro_Bandas()
        {
            string nome_Banda, nome_Album;
            int num_musicas;
            Console.Clear();// limpa a tela
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░" + "\n\n");

            Console.ResetColor();

            Console.WriteLine("Digite o nome da banda:");
            nome_Banda=Console.ReadLine();

            Console.WriteLine("Digite o nome do Álbum:");
            nome_Album = Console.ReadLine();

            Console.WriteLine("Digite o numero de musicas");
            num_musicas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro realizado com sucesso");
            Console.WriteLine($"{nome_Banda}\n{nome_Album}\n{num_musicas}");

            Thread.Sleep(2000);


        }


        static void Cadastro_Artista()
        {

            // Nome do artista, Ano , qtd_album, qtd vendas
            string nome_Artista;
            int ano_lancamento, qtd_album, qtd_vendas;
            Console.Clear();// limpa a tela
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝" + "\n\n");

            Console.ResetColor();

            Console.WriteLine("Digite o nome do artista:");
            nome_Artista = Console.ReadLine();

            Console.WriteLine("Digite o Ano de lançamento do album");
            ano_lancamento =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de albuns");
            qtd_album = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de vendas em milhoes");
            qtd_vendas = int.Parse(Console.ReadLine());


            Console.WriteLine("\nCadastro realizado com sucesso");
            Console.WriteLine($"{nome_Artista}\n{ano_lancamento}\n{qtd_album}\n{qtd_vendas}");

            Thread.Sleep(2000);


        }



        static void Cadastro_Musica()
        {

            //digitar a quantidade de musicas que vai ser cadastradas Nome da musica, Duração, premiação
            string nome_musica, premiacao;
            int duracao_min, duracao_seg, qtd_cad_musica;
            Console.Clear();// limpa a tela
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝" + "\n\n");

            Console.ResetColor();

            Console.WriteLine("Digite quantas musica voce deseja cadastrar");
            qtd_cad_musica = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd_cad_musica; i++)
            {

                Console.WriteLine("Digite o nome da música:");
                nome_musica = Console.ReadLine();

                Console.WriteLine("Digite o nome da premiação que essa musica lançou:");
                premiacao = Console.ReadLine();

                Console.WriteLine("Digite o tempo da musica ");
                Console.WriteLine("Minutos:");
                duracao_min = int.Parse(Console.ReadLine());
                Console.WriteLine("Segundos:");
                duracao_seg = int.Parse(Console.ReadLine());
                Console.WriteLine("\nCadastro realizado com sucesso");
                Console.WriteLine($"{nome_musica}\n{premiacao}\n{duracao_min}:{duracao_seg}\n\n");

            }


            Thread.Sleep(2000);


        }











    }
}
