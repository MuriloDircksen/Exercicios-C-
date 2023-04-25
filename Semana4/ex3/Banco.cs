using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Banco
    {
        private double _saldo;

        public Banco()
        {

        }
        public Banco(double saldo) {
        _saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if(valor >= 0)
            {
                _saldo += valor;
            }
        }

        public void Saca(double valor)
        {
            if (valor >= 0 && valor <= _saldo) {
                _saldo -= valor;
            }
        }

        public String ToString()
        {
            return $"Saldo: {_saldo.ToString("C")}";
        }
    }
}
