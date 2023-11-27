using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá\nSeja bem-vindo a sua calculadora de taxa de metabolismo basal\nQual o seu nome?");
            string nome = (Console.ReadLine());

            Console.WriteLine("Olá, " + nome + "\nFarei algumas perguntas para você\nVocê é homem ou mulher?");
            string genero = (Console.ReadLine());

            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura em CM?");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso em KG?");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione abaixo qual seu nivel de atividade fisica");
            Console.WriteLine("1. Nenhuma atividade fisica");
            Console.WriteLine("2. Atividade fisica moderada (3-5x  na semana)");
            Console.WriteLine("3. Avançado (ATLETA)");
            int atividade = int.Parse(Console.ReadLine());

            float calculohomem = 88.36f + (13.4f * peso) + (4.8f * altura) - (5.7f * idade);
            float calculomulher = 447.6f + (9.2f * peso) + (3.1f * altura) - (4.3f * idade);
            int diet = 500;
            float result = 0;


            if (genero.ToLower() == "homem")
            {
                if (atividade == 1)
                    result = calculohomem * 1.2f;

                else if (atividade == 2)
                    result = calculohomem * 1.55f;

                else  if (atividade == 3)
                    result = calculohomem * 1.9f;
            }


           else if (genero.ToLower() == "mulher")
            {
                if (atividade == 1)
                    result = calculomulher * 1.2f;
          
                else if (atividade == 2)
                    result = calculomulher * 1.55f;

                else if (atividade == 3)
                    result = calculomulher * 1.9f;
            }
            
            

            string taxaMetabolismo = genero == "homem" ? calculohomem.ToString() : calculomulher.ToString();

            Console.WriteLine($"Sua taxa de metabolismo basal é: {taxaMetabolismo}");
            Console.WriteLine($"Seu gasto calórico é de: {result}");
            Console.WriteLine("Deseja ver seu consumo calorico para défict e superavit calórico? (S/N)");

            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {
                float calc = result + diet;
                float calc2 = result - diet;

                Console.WriteLine($"Para um défict calórico, deverá consumir {calc2}");
                Console.WriteLine($"Para um superávit calórico, deverá consumir {calc}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Muito obrigado por utilizar a calculadora!");
                Console.ReadLine();
            }







        }
    }
}
