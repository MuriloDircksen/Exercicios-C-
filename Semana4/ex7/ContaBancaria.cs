using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class ContaBancaria
    {
        public const double SaldoMax = 1000.00;
        private int _numeroDaConta;
        private double _saldo;

        public double Saldo { get => _saldo; set => _saldo = value; }

        public void Depositar(double valor)
        {            
            if (valor < 0 || (valor+Saldo) > SaldoMax)
            {
                Console.WriteLine("Valor de deposito não permitido!");
            }
            else { Saldo += valor; }
        }
        public void Sacar(double valor)
        {
            if (valor < 0 && valor > Saldo)
            {
                Console.WriteLine("Valor de saque não permitido!");
            }
            else { Saldo -= valor; }
        }
    }
}
