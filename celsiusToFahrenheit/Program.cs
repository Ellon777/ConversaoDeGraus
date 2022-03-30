using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
            while (resposta == "S")
            {
                Console.WriteLine("Escolha sua preferência: ");
                Console.WriteLine("Digite 1 para - Converter de Celsius para Fahrenheit.");
                Console.WriteLine("Digite 2 para - Converter de Fahrenheit para Celsius.");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite os graus Celcius: ");
                        double celsius = double.Parse(Console.ReadLine());

                        double fahrenheit = (celsius * 9 / 5) + 32;

                        Console.WriteLine("Graus em Fahrenheit: " + fahrenheit);
                        break;
                    case 2:
                        Console.Write("Digite os graus Fahrenheit: ");
                        double fahrenheit1 = double.Parse(Console.ReadLine());

                        double celsius1 = (fahrenheit1 - 32) * 5 / 9;

                        Console.WriteLine("Graus em Celsius: " + celsius1);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }
                Console.WriteLine("Deseja retornar ao menu?(S/N)");
                resposta = Console.ReadLine();
                Console.Clear();
            }

               
        }
    }
}
