using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Internacao_Hospitalar
{

    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TipoSanguineo { get; set; }
        public string Alergias { get; set; }
        public string ContatoEmergencia { get; set; }
    }

    
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public string Telefone { get; set; }
    }

  
    public class Leito
    {
        public int Id { get; set; }
        public string NumeroQuarto { get; set; }
        public string Tipo { get; set; }
        public bool EstaOcupado { get; set; }
    }

  
    public class Internacao
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoResponsavelId { get; set; }
        public int LeitoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataAlta { get; set; }
        public string DiagnosticoEntrada { get; set; }
        public string Status { get; set; }
    }


    internal class Program
    {

        static List<Paciente> pacientes = new List<Paciente>();
        static List<Medico> medicos = new List<Medico>();
        static List<Leito> leitos = new List<Leito>();
        static List<Internacao> internacoes = new List<Internacao>();

        static int proximoIdPaciente = 1;
        static int proximoIdMedico = 1;
        static int proximoIdLeito = 1;
        static int proximoIdInternacao = 1;


        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
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
            Paciente paciente = new Paciente();

            paciente.Id = proximoIdPaciente++;

            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("          CADASTRO DE PACIENTE");
            Console.WriteLine("==========================================");

            Console.Write("Nome: ");
            paciente.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            paciente.CPF = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            paciente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Tipo sanguíneo: ");
            paciente.TipoSanguineo = Console.ReadLine();

            Console.Write("Alergias: ");
            paciente.Alergias = Console.ReadLine();

            Console.Write("Contato de emergência: ");
            paciente.ContatoEmergencia = Console.ReadLine();

            pacientes.Add(paciente);

            
            Console.WriteLine("\nPaciente cadastrado com sucesso!");
            Thread.Sleep(2000);

        }

        static void CadastrarMedico()
        {
            Medico medico = new Medico();

            medico.Id = proximoIdMedico++;

            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("            CADASTRO DE MÉDICO");
            Console.WriteLine("==========================================");

            Console.Write("Nome: ");
            medico.Nome = Console.ReadLine();

            Console.Write("CRM: ");
            medico.CRM = Console.ReadLine();

            Console.Write("Especialidade: ");
            medico.Especialidade = Console.ReadLine();

            Console.Write("Telefone: ");
            medico.Telefone = Console.ReadLine();

            medicos.Add(medico);

            Console.WriteLine("\nMédico cadastrado com sucesso!");
            Thread.Sleep(2000);
        }



        static void CadastrarLeito()
        {
            Leito leito = new Leito();

            leito.Id = proximoIdLeito++;

            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("             CADASTRO DE LEITO");
            Console.WriteLine("==========================================");

            Console.Write("Número do quarto/ala: ");
            leito.NumeroQuarto =
                Console.ReadLine();

            Console.Write("Tipo do leito: ");
            leito.Tipo = Console.ReadLine();

            Console.Write("Está ocupado? (true/false): ");
            leito.EstaOcupado = bool.Parse(Console.ReadLine());

            leitos.Add(leito);

            Console.WriteLine("\nLeito cadastrado com sucesso!");
            Thread.Sleep(2000);
        }

        static void RegistrarInternacao()
        {
            Internacao internacao = new Internacao();

            internacao.Id = proximoIdInternacao++;

            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("         REGISTRAR INTERNAÇÃO");
            Console.WriteLine("==========================================");

            Console.Write("ID do paciente: ");
            internacao.PacienteId = int.Parse(Console.ReadLine());

            Console.Write("ID do médico responsável: ");
            internacao.MedicoResponsavelId = int.Parse(Console.ReadLine());

            Console.Write("ID do leito: ");
            internacao.LeitoId = int.Parse(Console.ReadLine());

            Console.Write("Data de entrada: ");
            internacao.DataEntrada = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de alta: ");
            internacao.DataAlta = DateTime.Parse(Console.ReadLine());

            Console.Write("Diagnóstico de entrada: ");
            internacao.DiagnosticoEntrada = Console.ReadLine();

            Console.Write("Status: ");
            internacao.Status = Console.ReadLine();

            internacoes.Add(internacao);

          
            Console.WriteLine("\nInternação cadastrada com sucesso!");
            Thread.Sleep(2000);
        }


        static void DarAltaHospitalar()
        {
            Internacao internacao = new Internacao();

            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("           DAR ALTA HOSPITALAR");
            Console.WriteLine("==========================================");

            Console.Write("ID da internação: ");
            internacao.Id = int.Parse(Console.ReadLine());

            Console.Write("Data de alta: ");
            internacao.DataAlta = DateTime.Parse(Console.ReadLine());

            Console.Write("Status: ");
            internacao.Status = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Alta hospitalar registrada!");
            Thread.Sleep(2000);
        }

        static void ListarPacientesInternados()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("       PACIENTES INTERNADOS");
            Console.WriteLine("==========================================");

            foreach (Internacao internacao in internacoes)
            {
                Console.WriteLine();
                Console.WriteLine("ID da internação: " + internacao.Id);

                Console.WriteLine("Paciente ID: " + internacao.PacienteId);

                Console.WriteLine("Médico ID: " + internacao.MedicoResponsavelId);

                Console.WriteLine("Leito ID: " + internacao.LeitoId);

                Console.WriteLine("Data de entrada: " + internacao.DataEntrada.ToString("dd/MM/yyyy HH:mm"));

                Console.WriteLine("Data de alta: " + internacao.DataAlta);

                Console.WriteLine("Diagnóstico: " + internacao.DiagnosticoEntrada);

                Console.WriteLine("Status: " + internacao.Status);
            }

            Console.WriteLine("\n\nPressione Enter para voltar");
            Console.ReadKey();

        }


        static void ExibirRelatorioGeral()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("          RELATÓRIO GERAL DO HOSPITAL");
            Console.WriteLine("==================================================");

            // PACIENTES
          

            if (proximoIdPaciente > 1)
            {

            Console.WriteLine("\n========== PACIENTES ==========");

                foreach (Paciente paciente in pacientes)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + paciente.Id);
                    Console.WriteLine("Nome: " + paciente.Nome);
                    Console.WriteLine("CPF: " + paciente.CPF);
                    Console.WriteLine("Data de nascimento: " +
                        paciente.DataNascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Tipo sanguíneo: " +
                        paciente.TipoSanguineo);
                    Console.WriteLine("Alergias: " +
                        paciente.Alergias);
                    Console.WriteLine("Contato de emergência: " +
                        paciente.ContatoEmergencia);
                }
            }
            // MÉDICOS

         

            if (proximoIdMedico > 1)
            {

            Console.WriteLine("\n========== MÉDICOS ==========");

                foreach (Medico medico in medicos)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + medico.Id);
                    Console.WriteLine("Nome: " + medico.Nome);
                    Console.WriteLine("CRM: " + medico.CRM);
                    Console.WriteLine("Especialidade: " +
                        medico.Especialidade);
                    Console.WriteLine("Telefone: " +
                        medico.Telefone);
                }

            }
            // LEITOS

            if (proximoIdLeito > 1)
            {

            Console.WriteLine("\n========== LEITOS ==========");

                foreach (Leito leito in leitos)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + leito.Id);
                    Console.WriteLine("Quarto/Ala: " +
                        leito.NumeroQuarto);
                    Console.WriteLine("Tipo: " +
                        leito.Tipo);
                    Console.WriteLine("Está ocupado: " +
                        leito.EstaOcupado);
                }
            }
            // INTERNAÇÕES
           
            if (proximoIdInternacao > 1)
            {

            Console.WriteLine("\n========== INTERNAÇÕES ==========");

                foreach (Internacao internacao in internacoes)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " +
                        internacao.Id);

                    Console.WriteLine("Paciente ID: " +
                        internacao.PacienteId);

                    Console.WriteLine("Médico responsável ID: " +
                        internacao.MedicoResponsavelId);

                    Console.WriteLine("Leito ID: " +
                        internacao.LeitoId);

                    Console.WriteLine("Data de entrada: " +
                        internacao.DataEntrada.ToString(
                            "dd/MM/yyyy HH:mm"));

                    Console.WriteLine("Data de alta: " +
                        internacao.DataAlta);

                    Console.WriteLine("Diagnóstico: " +
                        internacao.DiagnosticoEntrada);

                    Console.WriteLine("Status: " +
                        internacao.Status);
                }
            }

            Console.WriteLine("\n\nPressione Enter para voltar");
            Console.ReadKey();

        }
    }
}
