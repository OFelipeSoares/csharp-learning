using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Aluno
    {
        string nome;
        public static void Main()
        {
            //Instanciando o obj ALUNO
            Aluno aluno = new Aluno();

            //Executando método setNome para colocar o nome do Aluno
            aluno.setNome("Carlos");

            //Escrevendo o nome do aluno no console utilizando getNome
            Console.WriteLine(aluno.getNome());

        }
        void setNome(string n)
        {
            nome = n;
        }
        void getNome()
        {
            return nome;
        }
    }
}