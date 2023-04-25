using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Cliente
    {
        private string _nome;
        private string _cpf;

        public Cliente(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }

        public string ToString() {
            return $"Nome: {_nome}, CPF: {_cpf}";
        }
    }
}
