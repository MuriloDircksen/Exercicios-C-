using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        private int _idade;
        public int Idade {
            get { return _idade; }
            set { 
                if(value > 0) _idade = value;
                else _idade = 0;
            } 
        }
        public void DefinirIdade(int idade)
        {
            if(idade > 0) Idade = idade;
        }
    }
}
