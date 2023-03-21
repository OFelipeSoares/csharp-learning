using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta.cs
{
    internal class Conta
    {
        public int numero; //Alterada a nivel de visibilidade do método
        public double saldo;

        public Cliente titular;
        
        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;

        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

        /*
        public int GetNumero
        {
            get { return this.numero; }// o Bloco GET lê um parâmetro
        }
        public int SetNumero; 
        {
            set { this.numero = value; }// o Bloco SET escreve um parâmetro
        }*/


        // Uma outra forma é utilizar o Auto-Implemented Properties
        public int Numero { get; private set; }
        /*public double PegaSaldo()
        {
            return this.saldo;
        }
        public void ColocaNumero(int numero)
        {
            this.numero = numero;
        }*/
    }
}
