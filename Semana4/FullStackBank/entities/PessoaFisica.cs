using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBank.entities
{
    internal class PessoaFisica : Cliente
    { 

        public string Cpf { get; }

        public PessoaFisica() { }
    
        public PessoaFisica(string nome, int numeroConta, string telefone, decimal saldo, string endereco, string cpf) : base(nome, numeroConta, telefone, saldo, endereco)
        {
            Cpf = cpf;
        }

        public bool EhMaior(int idade)
        {
            if (idade > 17) return true;
           
            return false;
        }
    }
}
