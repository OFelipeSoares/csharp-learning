using System;

namespace Banco
{
    public class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        internal void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        internal void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}