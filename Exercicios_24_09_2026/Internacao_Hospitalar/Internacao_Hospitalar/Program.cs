using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Internacao_Hospitalar
{
   
    internal class Program
    {

        public static class Paciente
        {
            public static int Id;
            public static string Nome;
            public static string CPF;
            public static DateTime DataNascimento;
            public static string TipoSanguineo;
            public static string Alergias;
            public static string ContatoEmergencia;
        }


        public static class Medico
        {
            public static int Id;
            public static string Nome;
            public static string CRM;
            public static string Especialidade;
            public static string Telefone;
        }

        public static class Leito
        {
            public static int Id;
            public static string NumeroQuarto;
            public static string Tipo;
            public static bool EstaOcupado;
        }

        public static class Internacao
        {
            public static int Id;
            public static int PacienteId;
            public static int MedicoResponsavelId;
            public static int LeitoId;
            public static DateTime DataEntrada;
            public static DateTime? DataAlta=null;
            public static string DiagnosticoEntrada;
            public static string Status;
        }

        public static class Alta
        {
            public static int Id;
            public static int InternacaoId;
            public static int MedicoResponsavelId;
            public static int PacienteId;
            public static DateTime? DataAlta;
            public static string ObservacaoAlta;

        }

        

        static int proximoIdPaciente = 1;
        static int proximoIdMedico = 1;
        static int proximoIdLeito = 1;
        static int proximoIdInternacao = 1;
        static int proximoIdAlta = 1;

        static int internados = 0;

        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==================================================");
                Console.WriteLine("        SISTEMA DE INTERNAÇÃO HOSPITALAR");
                Console.WriteLine("==================================================");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Cadastrar Médico");
                Console.WriteLine("3 - Cadastrar Leito");
                Console.WriteLine("4 - Registrar Internação (Admissão)");
                Console.WriteLine("5 - Dar Alta Hospitalar");
                Console.WriteLine("6 - Listar Pacientes Internados");
                Console.WriteLine("7 - Exibir Relatório Geral do Hospital");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarPaciente();
                        break;

                    case 2:
                        CadastrarMedico();
                        break;

                    case 3:
                        CadastrarLeito();
                        break;

                    case 4:
                        RegistrarInternacao();
                        break;

                    case 5:
                        DarAltaHospitalar();
                        break;

                    case 6:
                        ListarPacientesInternados();
                        break;

                    case 7:
                        ExibirRelatorioGeral();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do Programa");
                        Thread.Sleep(2000);
                        break;

                }

               

            } while (opcao != 0);

        }


        static void CadastrarPaciente()
        {
           

            Paciente.Id = proximoIdPaciente++;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================");
            Console.WriteLine("          CADASTRO DE PACIENTE");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("Paciente ID: "+Paciente.Id);

            Console.Write("Nome: ");
            Paciente.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            Paciente.CPF = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            Paciente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Tipo sanguíneo: ");
            Paciente.TipoSanguineo = Console.ReadLine();

            Console.Write("Alergias: ");
            Paciente.Alergias = Console.ReadLine();

            Console.Write("Contato de emergência: ");
            Paciente.ContatoEmergencia = Console.ReadLine();

           

            
            Console.WriteLine("\nPaciente cadastrado com sucesso!");
            Thread.Sleep(2000);

        }

        static void CadastrarMedico()
        {
            

            Medico.Id = proximoIdMedico++;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("            CADASTRO DE MÉDICO");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("Medico ID: "+ Medico.Id);

            Console.Write("Nome: ");
            Medico.Nome = Console.ReadLine();

            Console.Write("CRM: ");
            Medico.CRM = Console.ReadLine();

            Console.Write("Especialidade: ");
            Medico.Especialidade = Console.ReadLine();

            Console.Write("Telefone: ");
            Medico.Telefone = Console.ReadLine();

           

            Console.WriteLine("\nMédico cadastrado com sucesso!");
            Thread.Sleep(2000);
        }



        static void CadastrarLeito()
        {
            

            Leito.Id = proximoIdLeito++;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("             CADASTRO DE LEITO");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("Leito ID: "+Leito.Id);
            Console.Write("Número do quarto/ala: ");
            Leito.NumeroQuarto =
                Console.ReadLine();

            Console.Write("Tipo do leito: ");
            Leito.Tipo = Console.ReadLine();

            // Console.Write("Está ocupado? (true/false): ");
            // Leito.EstaOcupado = bool.Parse(Console.ReadLine());

            //leito inicia vazio
            Leito.EstaOcupado = false;

            Console.WriteLine("\nLeito cadastrado com sucesso!");
            Thread.Sleep(2000);
        }

        static void RegistrarInternacao()
        {
            

            Internacao.Id = proximoIdInternacao++;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("         REGISTRAR INTERNAÇÃO");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("Internação ID: "+Internacao.Id);

            Console.Write("ID do paciente: ");
            Internacao.PacienteId = int.Parse(Console.ReadLine());

            Console.Write("ID do médico responsável: ");
            Internacao.MedicoResponsavelId = int.Parse(Console.ReadLine());

            Console.Write("ID do leito: ");
            Internacao.LeitoId = int.Parse(Console.ReadLine());

            Console.Write("Data de entrada(dd/mm/aaaa HH:mm) : ");
            Internacao.DataEntrada = DateTime.Parse(Console.ReadLine());


            Console.Write("Diagnóstico de entrada: ");
            Internacao.DiagnosticoEntrada = Console.ReadLine();


            Internacao.Status = "Internado";

            internados++;

            //Reserva o Leito
            Leito.EstaOcupado = true;
          
            Console.WriteLine("\nInternação cadastrada com sucesso!");
            Thread.Sleep(2000);
        }


        static void DarAltaHospitalar()
        {
           
                Alta.Id = proximoIdAlta++;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("           DAR ALTA HOSPITALAR");
                Console.WriteLine("==========================================");
            Console.ResetColor();
            if (internados > 0)
            {

                Console.WriteLine("Alta ID: " + Alta.Id);

                Console.Write("ID da internação: ");
                Alta.InternacaoId = int.Parse(Console.ReadLine());
                Console.Write("ID do Paciente: ");
                Alta.PacienteId = int.Parse(Console.ReadLine());
                Console.Write("ID do Médico:");
                Alta.MedicoResponsavelId = int.Parse(Console.ReadLine());


                Console.Write("Data de alta(dd/mm/aaaa HH:mm): ");

                Internacao.DataAlta = DateTime.Parse(Console.ReadLine());
                Alta.DataAlta = Internacao.DataAlta;


                Console.Write("Observações: ");
                Alta.ObservacaoAlta = Console.ReadLine();

                Internacao.Status = "Alta Concluida";

                internados--;
                // libera o leito
                Leito.EstaOcupado = false;

                Console.WriteLine();
                Console.WriteLine("Alta hospitalar registrada!");
                Thread.Sleep(2000);
            }
            else
            {
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Nao há pacientes internados");
                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ResetColor();
                Console.ReadKey();
            }


           
        }

        static void ListarPacientesInternados()
        {
                Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================");
                Console.WriteLine("       PACIENTES INTERNADOS");
                Console.WriteLine("==========================================");
            Console.ResetColor();

            if (internados >0)
            {

                Console.WriteLine("ID da internação: " + Internacao.Id);

                Console.WriteLine("Paciente ID: " + Internacao.PacienteId);

                Console.WriteLine("Médico ID: " + Internacao.MedicoResponsavelId);

                Console.WriteLine("Leito ID: " + Internacao.LeitoId);

                Console.WriteLine("Data de entrada: " + Internacao.DataEntrada.ToString("dd/MM/yyyy HH:mm"));

                Console.WriteLine("Data de alta: " + Internacao.DataAlta);

                Console.WriteLine("Diagnóstico: " + Internacao.DiagnosticoEntrada);

                Console.WriteLine("Status: " + Internacao.Status);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ResetColor();
                Console.ReadKey();

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Nao há pacientes internados");
                Console.WriteLine("\n\nPressione Enter para voltar");
                Console.ResetColor();
                Console.ReadKey();
            }

        }


        static void ExibirRelatorioGeral()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("          RELATÓRIO GERAL DO HOSPITAL");
            Console.WriteLine("==================================================");
            Console.ResetColor();
            // PACIENTES
          

            if (proximoIdPaciente > 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n========== PACIENTES ==========");
                Console.ResetColor();
                
                
                    Console.WriteLine();
                    Console.WriteLine("ID: " + Paciente.Id);
                    Console.WriteLine("Nome: " + Paciente.Nome);
                    Console.WriteLine("CPF: " + Paciente.CPF);
                    Console.WriteLine("Data de nascimento: " +
                        Paciente.DataNascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Tipo sanguíneo: " +
                        Paciente.TipoSanguineo);
                    Console.WriteLine("Alergias: " +
                        Paciente.Alergias);
                    Console.WriteLine("Contato de emergência: " +
                        Paciente.ContatoEmergencia);
                
            }

            // MÉDICOS

         

            if (proximoIdMedico > 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n========== MÉDICOS ==========");
                Console.ResetColor();
                
                    Console.WriteLine();
                    Console.WriteLine("ID: " + Medico.Id);
                    Console.WriteLine("Nome: " + Medico.Nome);
                    Console.WriteLine("CRM: " + Medico.CRM);
                    Console.WriteLine("Especialidade: " +
                        Medico.Especialidade);
                    Console.WriteLine("Telefone: " +
                        Medico.Telefone);
                

            }
            // LEITOS

            if (proximoIdLeito > 1)
            {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========== LEITOS ==========");

                Console.ResetColor();

                Console.WriteLine();
                    Console.WriteLine("ID: " + Leito.Id);
                    Console.WriteLine("Quarto/Ala: " +
                        Leito.NumeroQuarto);
                    Console.WriteLine("Tipo: " +
                        Leito.Tipo);
                    Console.WriteLine("Está ocupado: " +
                        (Leito.EstaOcupado? "Sim":"Não"));
                
            }
            // INTERNAÇÕES
           
            if (proximoIdInternacao > 1)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n========== INTERNAÇÕES ==========");
                Console.ResetColor();

                    Console.WriteLine();
                    Console.WriteLine("ID: " +
                        Internacao.Id);

                    Console.WriteLine("Paciente ID: " +
                        Internacao.PacienteId);

                    Console.WriteLine("Médico responsável ID: " +
                        Internacao.MedicoResponsavelId);

                    Console.WriteLine("Leito ID: " +
                        Internacao.LeitoId);

                    Console.WriteLine("Data de entrada: " +
                        Internacao.DataEntrada.ToString(
                            "dd/MM/yyyy HH:mm"));

                    Console.WriteLine("Data de alta: " +
                        Alta.DataAlta?.ToString(
                        "dd/MM/yyyy HH:mm"));

                    Console.WriteLine("Diagnóstico: " +
                            Internacao.DiagnosticoEntrada);

                    Console.WriteLine("Status: " +
                        Internacao.Status);
                
                
            }



            if (proximoIdAlta > 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n========== ALTAS ==========");
                Console.ResetColor ();
                Console.WriteLine();
                Console.WriteLine("ID: " +
                    Alta.Id);

                Console.WriteLine("Internacao ID: " +
                        Alta.InternacaoId);

                Console.WriteLine("Paciente ID: " +
                         Alta.PacienteId);

                Console.WriteLine("Médico responsável ID: " +
                    Alta.MedicoResponsavelId);

                Console.WriteLine("Data de alta: " +
                        Alta.DataAlta?.ToString(
                            "dd/MM/yyyy HH:mm"));

                Console.WriteLine("Observações: " +
                        Alta.ObservacaoAlta);

            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nPressione Enter para voltar");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
