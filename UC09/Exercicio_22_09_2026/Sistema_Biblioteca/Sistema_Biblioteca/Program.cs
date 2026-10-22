using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha=1;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
==================================================
         SISTEMA DE GESTÃO DE BIBLIOTECA        
==================================================");

                Console.WriteLine("1- Cadastrar Livro");
                Console.WriteLine("2- Cadastrar Jogo");
                Console.WriteLine("3- Cadastrar Cliente");
                Console.WriteLine("4- Cadastrar Fornecedor");
                Console.WriteLine("5- Cadastrar Empréstimo");
                Console.WriteLine("0-Sair");

                Console.WriteLine(
                    "================================================== "); ;

                Console.WriteLine("Escolha uma Opção:");
                Console.ResetColor();
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        CadastraLivro();
                        break;
                    case 2:
                        CadastraJogo();
                        break;
                    case 3:
                        CadastraCliente();
                        break;
                    case 4:
                        CadastraFornecedor();
                        break;
                    case 5:
                        CadastraEmprestimo();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do Programa");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        Thread.Sleep(2000);
                        break;
                }
            } while (escolha != 0);
        }

        static void CadastraLivro()
        {
            int decisao;
            do
            {

                Console.Clear();
                Console.WriteLine(@"
==================================================
             CADASTRAR LIVRO       
==================================================");

                int id, ano_publicacao, quantidade_exemplares;
                string titulo, autor, isbn, genero;

                Console.WriteLine("Informe o Id numerico do livro:");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o titulo do livro");
                titulo = Console.ReadLine();
                Console.WriteLine("Informe o Autor do livro");
                autor = Console.ReadLine();
                Console.WriteLine("Inform o ISBN do livro");
                isbn = Console.ReadLine();
                Console.WriteLine("Informe o ano em que foi publicado");
                ano_publicacao = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Genero do livro");
                genero = Console.ReadLine();
                Console.WriteLine("informe a quantidade de exemplares");
                quantidade_exemplares = int.Parse(Console.ReadLine());


                Console.WriteLine("\nCadastro realizado com sucesso");
                Console.WriteLine($"{id}\n{titulo}\n{autor}\n{isbn}\n{ano_publicacao}\n{genero}\n{quantidade_exemplares}");

                Thread.Sleep(2000);

                Console.WriteLine("Deseja Cadastrar outro?");
                Console.WriteLine("1-Sim");
                Console.WriteLine("2-Não");
                decisao=int.Parse(Console.ReadLine());
                if (decisao == 1)
                {
                    decisao = 1;
                }
                else
                {
                    decisao = 0;
                }
            } while (decisao != 0);

        }

        static void CadastraJogo()
        {
            int decisao;
            do { 


            Console.Clear();

            Console.WriteLine(@"
==================================================
             CADASTRAR JOGO    
==================================================");

            int id, faixa_etaria, num_min_jogdores, num_max_jogdores, quantidade_exemplares;
            string nome, categoria;
            Console.WriteLine("Informe o Id numerico do jogo:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do jogo");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a categoria do jogo");
            categoria = Console.ReadLine();
            Console.WriteLine("Informe a faixa etaria do jogo");
            faixa_etaria = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Numero minimo de jogadores");
            num_min_jogdores = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero maximo de jogadores");
            num_max_jogdores= int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de exemplares");
            quantidade_exemplares= int.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro realizado com sucesso");
            Console.WriteLine($"{id}\n{nome}\n{categoria}\n{faixa_etaria}\n{num_min_jogdores}\n{num_max_jogdores}\n{quantidade_exemplares}");

            Thread.Sleep(2000);

                Console.WriteLine("Deseja Cadastrar outro?");
                Console.WriteLine("1-Sim");
                Console.WriteLine("2-Não");
                decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    decisao = 1;
                }
                else
                {
                    decisao = 0;
                }
            } while (decisao != 0);

        }

        static void CadastraCliente()
        {
            int decisao;
            do { 

            Console.Clear();
            Console.WriteLine(@"
==================================================
         CADASTRAR CLIENTE       
==================================================");
            int id;
            string nome, cpf, telefone, email;
            DateTime data_nascimento;
            bool ativo;

            Console.WriteLine("Informe o Id numerico do cliente:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do cliente");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do cliente");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe o telefone do cliente");
            telefone = Console.ReadLine();
            Console.WriteLine("Informe o email do cliente");
            email = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento do cliente(formato 00/00/0000");
            data_nascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe se o cliente ainda continua ativo (true / false)");
            ativo=bool.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro realizado com sucesso");
            Console.WriteLine($"{id}\n{nome}\n{cpf}\n{telefone}\n{email}\n{data_nascimento.ToString("dd/MM/yyyy")}\n{ativo}");

            Thread.Sleep(2000);

                Console.WriteLine("Deseja Cadastrar outro?");
                Console.WriteLine("1-Sim");
                Console.WriteLine("2-Não");
                decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    decisao = 1;
                }
                else
                {
                    decisao = 0;
                }
            } while (decisao != 0);


        }
        static void CadastraFornecedor()
        {
            int decisao;
            do { 

            Console.Clear();
            Console.WriteLine(@"
==================================================
         CADASTRAR FORNECEDOR       
==================================================");

            int id;
            string razao_social, cnpj, telefone, email, endeco;
            Console.WriteLine("Informe o Id numerico do fornecedor:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a RazãoSocial:");
            razao_social = Console.ReadLine();
            Console.WriteLine("Informe o CNPJ do Fornecedor");
            cnpj = Console.ReadLine();
            Console.WriteLine("Informe o telefone do fornecedor");
            telefone = Console.ReadLine();
            Console.WriteLine("Informe o email do fornecedor");
            email = Console.ReadLine();
            Console.WriteLine("informe o endereço do fornecedor");
            endeco = Console.ReadLine();


            Console.WriteLine("\nCadastro realizado com sucesso");
            Console.WriteLine($"{id}\n{razao_social}\n{cnpj}\n{telefone}\n{email}\n{endeco}");

            

            Thread.Sleep(2000);

                Console.WriteLine("Deseja Cadastrar outro?");
                Console.WriteLine("1-Sim");
                Console.WriteLine("2-Não");
                decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    decisao = 1;
                }
                else
                {
                    decisao = 0;
                }
            } while (decisao != 0);

        }

        static void CadastraEmprestimo()
        {

            int decisao;
            int id, client_id, item_id;
            string tipo_item;
            DateTime data_emprestimo, data_devolucao_prevista;
            bool devolvido;

            do { 
            Console.Clear();
            Console.WriteLine(@"
==================================================
         CADASTRAR EMPRESTIMO       
==================================================");

            
            Console.WriteLine("Informe o Id numerico:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id numerico do cliente:");
            client_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo de item (livro ou jogo)");
            tipo_item = Console.ReadLine();
            Console.WriteLine("Informe o Id do item:");
            item_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data do emprestimo: (00/00/0000)");
            data_emprestimo = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data prevista da devolução: (00/00/0000)");
            data_devolucao_prevista = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe se o item foi devolvido:(true/false)");
            devolvido=bool.Parse(Console.ReadLine());



            Console.WriteLine("\nCadastro realizado com sucesso");
            Console.WriteLine($"{id}\n{client_id}\n{tipo_item}\n{item_id}\n{data_emprestimo}\n{data_devolucao_prevista}\n{devolvido}");
            Thread.Sleep(2000);

                Console.WriteLine("Deseja Cadastrar outro?");
                Console.WriteLine("1-Sim");
                Console.WriteLine("2-Não");
                decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    decisao = 1;
                }
                else
                {
                    decisao = 0;
                }
            } while (decisao != 0);


        }

    }
}
