using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class ContaBancaria
    {
        private int NumeroDaConta;
        private double Saldo;

        public ContaBancaria(int numeroDaConta, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public void Deposita(double valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
            }
           
        }

        public void Saca(double valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
            }
            Console.WriteLine("O valor solicitado e maior que o saldo disponível ou negativo!");
        }
        public double GetSaldo()
        {
            return Saldo;
        }
    }
}
