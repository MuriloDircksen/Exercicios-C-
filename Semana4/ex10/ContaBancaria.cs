using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class ContaBancaria
    {
        private decimal _saldo;
        public decimal Saldo { 
            get { return _saldo; }
            private set { _saldo = value; } 
        }
        private List<string> _registrarTransacao = new List<string>();

        public void Depostio(decimal valor)
        {
            if(valor >= 0)
            {
                Saldo += valor;
                _registrarTransacao.Add($"Depósito de: {valor}");
            }
            else { Console.WriteLine("Valor inválido");}
        }
        public bool Saque(decimal valor)
        {

            if(valor >= 0 && valor <= Saldo) { 
                Saldo -= valor;
                _registrarTransacao.Add($"Saque de: {valor}");
                return true;
            }
            Console.WriteLine("Valor inválido"); 
            return false;
        }
        public decimal ConsultaSaldo()
        {
            return Saldo;
        }

        public void HistoricoTransacoes()
        {
            foreach(string transacao in _registrarTransacao)
            {
                Console.WriteLine(transacao);
            }
           
        }

    }
}
