using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class ContaBancaria
    {
        private double _saldo;

        public ContaBancaria(double saldo)
        {
            if (saldo < 0) { saldo = 0; }
            else Saldo = saldo;
        }

        public double Saldo { 
            get => _saldo;
            set {
                if (_saldo < 0) { _saldo = 0; }
                else _saldo = value; 
            } 
        }

        public void Depositar(double valor)
        {
            if(valor >= 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
