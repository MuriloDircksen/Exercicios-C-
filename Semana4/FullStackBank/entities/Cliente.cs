using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBank.entities
{
    internal abstract class Cliente
    {
        private string _nome;
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; }
        }
        private int _numeroConta;
        public int NumeroConta
        {
            get { return _numeroConta;}
            private set { _numeroConta = value;}
        }
        public string Telefone { get; set; }

        public decimal Saldo { get; set; }
        public string Endereco { get; set; }

        protected Cliente(string nome, int numeroConta, string telefone, decimal saldo, string endereco)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Telefone = telefone;
            Saldo = saldo;
            Endereco = endereco;
        }

        public void ResumoCliente()
        {
            Console.WriteLine($"Nome: {Nome}, Numero da Conta: {NumeroConta}, " +
                $"Telefone: {Telefone}\n, Saldo: {Saldo.ToString("C2")}, Endereço: {Endereco}");
        }
    }

}
