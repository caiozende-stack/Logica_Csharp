using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clinica_Podologia
{
    internal class Program
    {

        public static class ClientePodologia
        {
            public static int Id;
            public static string Nome;
            public static string CPF;
            public static string Telefone;
            public static DateTime Data_nascimento;
            public static bool Diabetes;
            public static string Observacao;
        }

        public static class Podologo
        {

            public static int Id;
            public static string Nome;
            public static string Registro_Profissional;
            public static string Especialidade;
            public static string Telefone;

        }
        public static class Procedimento
        {
            public static int Id;
            public static string Nome;
            public static int Duracao;
            public static double Valor;
        }

        public static class Agendamento
        {
            public static int Id;
            public static int ClientId;
            public static int PodologoId;
            public static int ProcedimentoId;

            public static DateTime DataHora;
            public static string Status;
        }

      static int proximoIdCliente = 1;
      static int proximoIdPodologo = 1;
      static int proximoIdProcedimento = 1;
      static int proximoIdAgendamento = 1;


        static void Main(string[] args)
        {

            int escolha;
          


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
==================================================
            CLINICA DE PODOLOGIA-AGENDAMENTOS        
==================================================");

                Console.WriteLine("1- Cadastrar Cliente");
                Console.WriteLine("2- Cadastrar Podólogo");
                Console.WriteLine("3- Cadastrar Procedimento/Serviço");
                Console.WriteLine("4- Agendar Consulta");
                Console.WriteLine("5- Listar Agendamentos");
                Console.WriteLine("6- Exibir todos os cadastros");
                Console.WriteLine("0-Sair");

                Console.WriteLine(
                    "================================================== "); ;

                Console.WriteLine("Escolha uma Opção:");
                Console.ResetColor();
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        CadastrarCliente();
                        break;
                    case 2:
                       CadastrarPodologo();
                        break;
                    case 3:
                        CadastrarProcedimento();
                        break;
                    case 4:
                        CadastrarAgendamento();
                        break;
                    case 5:
                        ListarAgendamentos();
                        break;
                    case 6:
                        ExibirTodosCadastros();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do Programa");
                        Thread.Sleep(2000);
                        break;

                    
                }
            } while (escolha != 0);


        }


        static void CadastrarCliente()
        {

            Console.Clear();
           

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE CLIENTE");
            Console.WriteLine("==========================================");


            ClientePodologia.Id = proximoIdCliente++;

            Console.Write("Nome completo: ");
            ClientePodologia.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            ClientePodologia.CPF = Console.ReadLine();

            Console.Write("Telefone: ");
            ClientePodologia.Telefone = Console.ReadLine();

            Console.Write("Data de nascimento (dd/MM/yyyy): ");
            ClientePodologia.Data_nascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Possui diabetes? (S/N): ");
            string diabete = Console.ReadLine();

            ClientePodologia.Diabetes = diabete.ToUpper() == "S";

            Console.Write("Observações da anamnese: ");
            ClientePodologia.Observacao = Console.ReadLine();

          
            Console.WriteLine("\nCliente cadastrado com sucesso!");
            Thread.Sleep(2000);

            




        }

        static void CadastrarPodologo()
        {

            Console.Clear();
            

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE PODOLOGO");
            Console.WriteLine("==========================================");


            Podologo.Id = proximoIdPodologo++;

            Console.Write("Nome completo: ");
            Podologo.Nome = Console.ReadLine();

            Console.Write("Registro Profissional: ");
            Podologo.Registro_Profissional = Console.ReadLine();

            Console.Write("Especialidade: ");
            Podologo.Especialidade = Console.ReadLine();

            Console.Write("Telefone: ");
            Podologo.Telefone = Console.ReadLine();

           

            Console.WriteLine("\nPodologo cadastrado com sucesso!");
            Thread.Sleep(2000);

        }

        static void CadastrarProcedimento()
        {
            Console.Clear();
           

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE PROCEDIMENTO");
            Console.WriteLine("==========================================");

            Procedimento.Id= proximoIdProcedimento++;

            Console.WriteLine("Nome:");
            Procedimento.Nome= Console.ReadLine();

            Console.WriteLine("Duração(minutos)");
            Procedimento.Duracao=int.Parse(Console.ReadLine());

            Console.WriteLine("Valor:");
            Procedimento.Valor=double.Parse(Console.ReadLine());

           
            
            Console.WriteLine("\n Procedimento realizado com sucesso!");
            Thread.Sleep(2000);
        }

        static void CadastrarAgendamento()
        {
            Console.Clear();
           

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE AGENDAMENTOS");
            Console.WriteLine("==========================================");

            Agendamento.Id = proximoIdAgendamento++;

            Console.Write("ID do cliente: ");
            Agendamento.ClientId = int.Parse(Console.ReadLine());

            Console.Write("ID do podólogo: ");
            Agendamento.PodologoId = int.Parse(Console.ReadLine());

            Console.Write("ID do procedimento: ");
            Agendamento.ProcedimentoId = int.Parse(Console.ReadLine());

            Console.Write("Data e hora da consulta (dd/MM/yyyy HH:mm): ");
            Agendamento.DataHora =DateTime.Parse(Console.ReadLine());

            Console.Write("Status: ");
            Agendamento.Status =Console.ReadLine();

           

          
            Console.WriteLine("\n Agendamento realizado com sucesso!");
            Thread.Sleep(2000);
        }

        static void ListarAgendamentos()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("          AGENDAMENTOS");
            Console.WriteLine("==========================================");

           
                
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("ID: " + Agendamento.Id);
                Console.WriteLine("Cliente ID: " + Agendamento.ClientId);
                Console.WriteLine("Podólogo ID: " + Agendamento.PodologoId);
                Console.WriteLine("Procedimento ID: " + Agendamento.ProcedimentoId);
                Console.WriteLine("Data/Hora: " +Agendamento.DataHora.ToString("dd/MM/yyyy HH:mm"));
                Console.WriteLine("Status: " +  Agendamento.Status);
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ReadKey();

            
        }

        static void ExibirTodosCadastros()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("             TODOS OS CADASTROS");
            Console.WriteLine("==================================================");

            // CLIENTES
            if (proximoIdCliente > 1)
            {
           
            Console.WriteLine("\n========== CLIENTES ==========");

               
                
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + ClientePodologia.Id);
                    Console.WriteLine("Nome: " + ClientePodologia.Nome);
                    Console.WriteLine("CPF: " + ClientePodologia.CPF);
                    Console.WriteLine("Telefone: " + ClientePodologia.Telefone);
                    Console.WriteLine("Data de nascimento: " + ClientePodologia.Data_nascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Possui diabetes: " + (ClientePodologia.Diabetes ? "Sim" : "Não"));
                    Console.WriteLine("Observações: " + ClientePodologia.Observacao);
                    Console.WriteLine("------------------------------------------");
                
            }

            // PODOLOGOS
            if (proximoIdPodologo > 1)
            {
                Console.WriteLine("\n ========== PODOLOGOS ==========");

                
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + Podologo.Id);
                    Console.WriteLine("Nome: " + Podologo.Nome);
                    Console.WriteLine("Registro profissional: " + Podologo.Registro_Profissional);
                    Console.WriteLine("Especialidade: " + Podologo.Especialidade);
                    Console.WriteLine("Telefone: " + Podologo.Telefone);
                    Console.WriteLine("------------------------------------------");
                

            }


            // PROCEDIMENTOS


            if (proximoIdProcedimento > 1)
            {

                Console.WriteLine("\n========== PROCEDIMENTOS ==========");

               
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + Procedimento.Id);
                    Console.WriteLine("Nome: " + Procedimento.Nome);
                    Console.WriteLine("Duração: " + Procedimento.Duracao + " minutos");
                    Console.WriteLine("Valor: R$ " + Procedimento.Valor.ToString("F2"));
                    Console.WriteLine("------------------------------------------");
                

            }

            // AGENDAMENTOS

            if (proximoIdAgendamento > 1)
            {

                Console.WriteLine("\n========== AGENDAMENTOS ==========");

                
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + Agendamento.Id);
                    Console.WriteLine("Cliente ID: " + Agendamento.ClientId);
                    Console.WriteLine("Podólogo ID: " + Agendamento.PodologoId);
                    Console.WriteLine("Procedimento ID: " + Agendamento.ProcedimentoId);
                    Console.WriteLine("Data/Hora: " + Agendamento.DataHora.ToString("dd/MM/yyyy HH:mm"));
                    Console.WriteLine("Status: " + Agendamento.Status);
                    Console.WriteLine("------------------------------------------");
                

            }
                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ReadKey();

        }
     }
}
