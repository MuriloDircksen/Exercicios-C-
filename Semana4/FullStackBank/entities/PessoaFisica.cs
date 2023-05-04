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

       
    
        public PessoaFisica(string nome, string telefone, string endereco, int numeroConta, string cpf) : base(nome, telefone,  endereco, numeroConta)
        {
            Cpf = cpf;
        }

        public bool EhMaior(int idade)
        {
            if (idade > 17) return true;
           
            return false;
        }

        public override void ResumoCliente()
        {
            Console.WriteLine($"Numero da Conta: {NumeroConta}, Nome: {Nome}, CPF: {Cpf}");
        }
    }
}
