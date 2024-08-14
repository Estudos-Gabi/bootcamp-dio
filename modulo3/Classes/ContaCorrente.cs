using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class ContaCorrente
    {
        public ContaCorrente(int numero, decimal saldoInicial)
        {
            NumeroConta = numero;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior do que disponível");
            } 
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}