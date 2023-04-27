using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class ContaBancaria 
    {
        private int _numero;
        private Cliente _cliente ;
        private Banco _banco = new Banco();

        public ContaBancaria(int numero, Cliente cliente)
        {
            _numero = numero;
            _cliente = cliente;
        }

        public string ExibirDados()
        {
            return $"Conta: {_numero}, {_cliente} ";
        }

        public void Depositar(double valor) { 
            _banco.Depositar(valor);
        }

        public void Saca(double valor)
        {
            _banco.Saca(valor);
        }

        public override string ToString()
        {
            return ExibirDados()+", "+ _banco;
        }
    }
}
