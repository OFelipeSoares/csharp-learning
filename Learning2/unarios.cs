using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class unario
    {
        public static void Main()
        {
            //Declaração das variávris
            int unario = 0;
            int preIncremento;
            int preDecremento;
            int posIncremento;
            int posDecremento;
            int positivo;
            int negativo;
            sbyte bitNao;
            bool logNao;

            //Início do Código

            preIncremento = ++unario;
            Console.WriteLine("Pré-Incremento: {0}", preIncremento);
            Console.WriteLine("Unário: {0}", unario);
            Console.WriteLine("");

            preDecremento = --unario;
            Console.WriteLine("Pré-Decremento: {0}", preDecremento);
            Console.WriteLine("Unário: {0}", unario);
            Console.WriteLine("");

            posDecremento = unario--;
            Console.WriteLine("Pos-Decremento: {0}", posDecremento);
            Console.WriteLine("Unário: {0}", unario);
            Console.WriteLine("");

            posIncremento = unario++;
            Console.WriteLine("Pos-Incremento: {0}", posIncremento);
            Console.WriteLine("Unário: {0}", unario);
            Console.WriteLine("");

            Console.WriteLine("Valor final do unário: {0}", unario);
            Console.WriteLine("");

            positivo = -posIncremento;
            Console.WriteLine("Positivo: {0}", positivo);

            negativo = +posIncremento;
            Console.WriteLine("Negativo: {0}", negativo);
            Console.WriteLine("");

            bitNao = 0;
            bitNao = (SByte)(~bitNao);
            Console.WriteLine("BitWise: {0}", bitNao);
            Console.WriteLine("");

            logNao = false;
            logNao = !logNao;
            Console.WriteLine("Não Lógico: {0}", logNao);
            Console.WriteLine("");

        }
    }
}