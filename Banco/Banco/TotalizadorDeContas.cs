﻿public class TotalizadorDeContas
{
    public public double SaldoTotal { get; private set; }

    public void Soma(Conta conta)
    {
        SaldoTotal = conta.Saldo;
    }

}
