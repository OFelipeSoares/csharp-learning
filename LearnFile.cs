using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //Criando um novo tipo de dado -> dado do tipo cor 
        enum cor {Azul, Verde, Amarelo, Vermelho, Preto } /*Todas as variáveis do tipo cor só poderão
        assumir uma das cores aqui definidas*/
        
        //CRIAÇÃO DE MENUS -> Usando Enum e switch
        enum Opcoes { Criar, Deletar, Editar, Listar, Atual}
        static void Main(string[] args)
        {
            cor CorFavorita = cor.Preto;
            Console.WriteLine(CorFavorita);
            Console.WriteLine((int)CorFavorita); //Conversão de um tipo para o outro -> Nesse caso, será exibido o íncice da cor preta
            Console.WriteLine((cor)2);// Aqui imprimirá a cor de índice 2
            /*ExibirMsg();
            GerarPreco(30);
            GerarPreco(20);
            GerarPreco(-20);*/
            int soma2 = Somar(10,20,30);
            int soma1 = Somar(1, 2, 3);
            int soma3 = Somar(100, 200, 300);
            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            string[] produtos = new string[]
            {
                "teste1",
                "Teste2",
                "t",
                "t",
                "t"
                
            };

            int[] valores = { 10, 20, 30, 40, 50 };

            Console.ReadLine();
        }

        static void /*Define o tipo de retorno da função*/ ExibirMsg()
        {
            Console.WriteLine("Frase 1");
            Console.WriteLine("Frase 2");
            Console.WriteLine("Frase 3");
        }

        static void GerarPreco(int preco/*, string nome*/)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = preco + (2 * preco);
            Console.WriteLine("O valor final é" + valorFinal);
           /* Console.WriteLine("O Nome do produto é" + nome);
            Console.WriteLine(preco);*/
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal; //Lembre-se de manter o return na última linha, pois códigos abaixo dele não serão executados

        }
        
    }
}
