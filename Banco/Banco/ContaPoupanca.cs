using System;

namespace Banco
{
    public class ContaPoupanca : Conta // Os : Representam herança entre classes. Desta forma, basta escrever a parte do código que sofrerá alteração 
    { 
    
        public override void Saca(double valor)
        {
            base.Saca(valor + 0.10);
        }
    
    } 
}