using FullStackBank.entities;
using FullStackBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBank.Services
{
    internal class ClienteService : IClienteService
    {
        List<Cliente> clientes = new List<Cliente>;

        public void CriaConta()
        {
            Console.WriteLine("Qual o tipo de conta, pessoa fisica(pf) ou pessoa juridica(pj)?");
            string tipoConta = Console.ReadLine();
            if (tipoConta == "pf") { }
            if (tipoConta == "pj") { }

            else Console.WriteLine("Opção inválida");
        }

        public void CadastroPF()
        {
            Console.WriteLine("Entre com os  dados do Cliente Pessoa Fisica:");
            Console.WriteLine("Nome Completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();

            clientes.Add(new PessoaFisica(nome, telefone, endereco, cpf));


        }
        public void CadastroPJ() 
        {
            Console.WriteLine("Entre com os  dados do Cliente Pessoa Juridica:");
            Console.WriteLine("Nome Completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("CNPJ: ");
            string cNPJ = Console.ReadLine();
            Console.WriteLine("Razão Social: ");
            string razaoSocial = Console.ReadLine();
            Console.WriteLine("Inscrição Estadual: ");
            string inscricaoEstadual = Console.ReadLine();

            clientes.Add(new PessoaJuridica(nome, telefone, endereco, cNPJ, razaoSocial, inscricaoEstadual));
        }

        public Cliente BuscaClientePorNumeroDeConta(int numeroConta)
        {           
            foreach (var cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    return cliente;
                }
            }
            return null;
        }
        public void ExibirClientes()
        {

            foreach (var cliente in clientes)
            {

                Console.WriteLine(cliente.ToString());

            }
        }
    }
}
