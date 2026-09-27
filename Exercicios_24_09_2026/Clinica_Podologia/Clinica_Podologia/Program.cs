using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clinica_Podologia
{


    public class ClientePodologia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_nascimento { get; set; }
        public bool Diabetes { get; set; }
        public string Observacao { get; set; }
    }

    public class Podologo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Registro_Profissional { get; set; }
        public string Especialidade { get; set; }
        public string Telefone { get; set; }

    }

    public class Procedimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public double Valor { get; set; }
    }

    public class Agendamento
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PodologoId { get; set; }
        public int ProcedimentoId {  get; set; }

        public DateTime DataHora{ get; set; }
        public string Status { get; set; }
    }


    internal class Program
    {

      static  List<ClientePodologia> clientes = new List<ClientePodologia>();
      static List<Podologo> podologos = new List<Podologo>();
      static List<Procedimento> procedimentos= new List<Procedimento>();
      static  List<Agendamento> agendamentos = new List<Agendamento>();

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
            ClientePodologia cliente= new ClientePodologia();

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE CLIENTE");
            Console.WriteLine("==========================================");


            cliente.Id = proximoIdCliente++;

            Console.Write("Nome completo: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("Data de nascimento (dd/MM/yyyy): ");
            cliente.Data_nascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Possui diabetes? (S/N): ");
            string diabete = Console.ReadLine();

            cliente.Diabetes = diabete.ToUpper() == "S";

            Console.Write("Observações da anamnese: ");
            cliente.Observacao = Console.ReadLine();

            clientes.Add(cliente);

           
            Console.WriteLine("\nCliente cadastrado com sucesso!");
            Thread.Sleep(2000);
        }

        static void CadastrarPodologo()
        {

            Console.Clear();
            Podologo podologo= new Podologo();

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE PODOLOGO");
            Console.WriteLine("==========================================");


            podologo.Id = proximoIdPodologo++;

            Console.Write("Nome completo: ");
            podologo.Nome = Console.ReadLine();

            Console.Write("Registro Profissional: ");
            podologo.Registro_Profissional = Console.ReadLine();

            Console.Write("Especialidade: ");
            podologo.Especialidade = Console.ReadLine();

            Console.Write("Telefone: ");
            podologo.Telefone = Console.ReadLine();

            podologos.Add(podologo);

            Console.WriteLine("\nPodologo cadastrado com sucesso!");
            Thread.Sleep(2000);

        }

        static void CadastrarProcedimento()
        {
            Console.Clear();
            Procedimento procedimento= new Procedimento();

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE PROCEDIMENTO");
            Console.WriteLine("==========================================");

            procedimento.Id= proximoIdProcedimento++;

            Console.WriteLine("Nome:");
            procedimento.Nome= Console.ReadLine();

            Console.WriteLine("Duração(minutos)");
            procedimento.Duracao=int.Parse(Console.ReadLine());

            Console.WriteLine("Valor:");
            procedimento.Valor=double.Parse(Console.ReadLine());

            procedimentos.Add(procedimento);
            
            Console.WriteLine("\n Procedimento realizado com sucesso!");
            Thread.Sleep(2000);
        }

        static void CadastrarAgendamento()
        {
            Console.Clear();
            Agendamento agendamento = new Agendamento();

            Console.WriteLine("==========================================");
            Console.WriteLine("       CADASTRO DE AGENDAMENTOS");
            Console.WriteLine("==========================================");

            agendamento.Id = proximoIdAgendamento++;

            Console.Write("ID do cliente: ");
            agendamento.ClientId = int.Parse(Console.ReadLine());

            Console.Write("ID do podólogo: ");
            agendamento.PodologoId = int.Parse(Console.ReadLine());

            Console.Write("ID do procedimento: ");
            agendamento.ProcedimentoId = int.Parse(Console.ReadLine());

            Console.Write("Data e hora da consulta (dd/MM/yyyy HH:mm): ");
            agendamento.DataHora =DateTime.Parse(Console.ReadLine());

            Console.Write("Status: ");
            agendamento.Status =Console.ReadLine();

            agendamentos.Add(agendamento);

          
            Console.WriteLine("\n Agendamento realizado com sucesso!");
            Thread.Sleep(2000);
        }

        static void ListarAgendamentos()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("          AGENDAMENTOS");
            Console.WriteLine("==========================================");

            foreach (Agendamento agendamento in agendamentos)
            {
                
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("ID: " + agendamento.Id);
                Console.WriteLine("Cliente ID: " + agendamento.ClientId);
                Console.WriteLine("Podólogo ID: " + agendamento.PodologoId);
                Console.WriteLine("Procedimento ID: " + agendamento.ProcedimentoId);
                Console.WriteLine("Data/Hora: " +agendamento.DataHora.ToString("dd/MM/yyyy HH:mm"));
                Console.WriteLine("Status: " +  agendamento.Status);
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ReadKey();

            }
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

                foreach (ClientePodologia cliente in clientes)
                {
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + cliente.Id);
                    Console.WriteLine("Nome: " + cliente.Nome);
                    Console.WriteLine("CPF: " + cliente.CPF);
                    Console.WriteLine("Telefone: " + cliente.Telefone);
                    Console.WriteLine("Data de nascimento: " + cliente.Data_nascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Possui diabetes: " + (cliente.Diabetes ? "Sim" : "Não"));
                    Console.WriteLine("Observações: " + cliente.Observacao);
                    Console.WriteLine("------------------------------------------");
                }
            }

            // PODOLOGOS
            if (proximoIdPodologo > 1)
            {
                Console.WriteLine("\n ========== PODOLOGOS ==========");

                foreach (Podologo podologo in podologos)
                {
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + podologo.Id);
                    Console.WriteLine("Nome: " + podologo.Nome);
                    Console.WriteLine("Registro profissional: " + podologo.Registro_Profissional);
                    Console.WriteLine("Especialidade: " + podologo.Especialidade);
                    Console.WriteLine("Telefone: " + podologo.Telefone);
                    Console.WriteLine("------------------------------------------");
                }

            }


            // PROCEDIMENTOS


            if (proximoIdProcedimento > 1)
            {

                Console.WriteLine("\n========== PROCEDIMENTOS ==========");

                foreach (Procedimento procedimento in procedimentos)
                {
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + procedimento.Id);
                    Console.WriteLine("Nome: " + procedimento.Nome);
                    Console.WriteLine("Duração: " + procedimento.Duracao + " minutos");
                    Console.WriteLine("Valor: R$ " + procedimento.Valor.ToString("F2"));
                    Console.WriteLine("------------------------------------------");
                }

            }

            // AGENDAMENTOS

            if (proximoIdAgendamento > 1)
            {

                Console.WriteLine("\n========== AGENDAMENTOS ==========");

                foreach (Agendamento agendamento in agendamentos)
                {
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("ID: " + agendamento.Id);
                    Console.WriteLine("Cliente ID: " + agendamento.ClientId);
                    Console.WriteLine("Podólogo ID: " + agendamento.PodologoId);
                    Console.WriteLine("Procedimento ID: " + agendamento.ProcedimentoId);
                    Console.WriteLine("Data/Hora: " + agendamento.DataHora.ToString("dd/MM/yyyy HH:mm"));
                    Console.WriteLine("Status: " + agendamento.Status);
                    Console.WriteLine("------------------------------------------");
                }

            }
                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ReadKey();

        }
     }
}
