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
        List<Cliente> clientes = new List<Cliente>();

        public void CriarConta()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Qual o tipo de conta, pessoa fisica(pf) ou pessoa juridica(pj)?");
            string tipoConta = Console.ReadLine();
            if (tipoConta == "pf") { CadastroPF(); }
            else if (tipoConta == "pj") { CadastroPJ(); }

            else Console.WriteLine("Opção inválida");
        }

        public void CadastroPF()
        {
            Console.WriteLine("Entre com os  dados do Cliente Pessoa Fisica:");
            Console.WriteLine("Numero Conta:");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome Completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();

            clientes.Add(new PessoaFisica(nome, telefone, endereco, numeroConta, cpf));


        }
        public void CadastroPJ() 
        {
            Console.WriteLine("Entre com os  dados do Cliente Pessoa Juridica:");
            Console.WriteLine("Numero Conta:");
            int numeroConta = int.Parse(Console.ReadLine());
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

            clientes.Add(new PessoaJuridica(nome, telefone, endereco, numeroConta, cNPJ, razaoSocial, inscricaoEstadual));
        }

        public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {           
            foreach (var cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    cliente.ResumoCliente();
                    return cliente;
                }
               
            }
            Console.WriteLine("Cliente não encontrado!");
            return null;
        }
        public void ExibirClientes()
        {

            foreach (var cliente in clientes)
            {
                cliente.ResumoCliente();

            }
        }
    }
}
