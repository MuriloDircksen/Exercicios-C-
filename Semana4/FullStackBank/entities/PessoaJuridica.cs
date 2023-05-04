﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBank.entities
{
    internal class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }

        public PessoaJuridica(string nome, string telefone, string endereco, 
            string cNPJ, string razaoSocial, string inscricaoEstadual) : base(nome, telefone, endereco)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
            InscricaoEstadual = inscricaoEstadual;
        }
    }
}
