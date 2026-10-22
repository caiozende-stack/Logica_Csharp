using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Diaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] temperatura = new double[7];
            string[] dias_semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado" };
        

            double temp_mais_quente=0;
            double temp_mais_frio= double.MaxValue;

            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.WriteLine("Qual a temperatura teve "+ dias_semana[i]);
                temperatura[i] = double.Parse(Console.ReadLine());

                if (temperatura[i] > temp_mais_quente)
                {
                   temp_mais_quente= temperatura [i];
                }
                if (temperatura[i] < temp_mais_frio) 
                { 
                    temp_mais_frio = temperatura [i];    
                }
            }

            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temp_mais_quente == temperatura[i])
                {
                    Console.WriteLine(" O dia mais quente foi " + dias_semana[i]+" que fez "+temp_mais_quente+" graus");
                }
            }

            for (int i = 0; i < temperatura.Length; i++)
            {

                if (temp_mais_frio == temperatura[i])
                {
                    Console.WriteLine(" O dia mais fria foi " + dias_semana[i] + " que fez " + temp_mais_frio+ " graus");
                }

            }
        }
    }
}
