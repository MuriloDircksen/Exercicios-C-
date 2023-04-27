using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    abstract class Animal
    {
        private string _nome;
        public string Nome { get; set; }
        private int _idade;
        public int Idade { get; set; }

        protected Animal(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public abstract void EmitirSom();
    }
}
