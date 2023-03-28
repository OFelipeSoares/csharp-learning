using System;

namespace Banco
{
    public class Conta
    {

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }
        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
            /*
             * if (this.Tipo == 1)
            {
                this.Saldo -= valor + 10;
            } else
            {
                this.Saldo -= valor;
            } 
            */
        }

        
        
    }
}