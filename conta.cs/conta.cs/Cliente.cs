using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta.cs
    {
    internal class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf;
        public string Rg;
        public string endereço;

        public Cliente (string nome)
        {
            this.Nome = nome;
        }
        public Cliente (string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
