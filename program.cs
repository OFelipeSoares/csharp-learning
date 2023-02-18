using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entradaDoUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11) {

                Console.WriteLine("Você é uma criança!");

            } else if (idade >= 12 && idade <= 17) {

               Console.WriteLine("Você é um adolescente!");

            } else if (idade >= 18 && idade <= 65) {
                
                Console.WriteLine("Você é um adulto!");

            }
            else {
                
                Console.WriteLine("Você é um idoso!");

            }
            Console.ReadLine();
            /* string nome = "";
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine(); */
        }
    }
}
