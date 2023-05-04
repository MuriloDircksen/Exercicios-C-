using FullStackBank.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBank.Services
{
    internal class ClienteService
    {
        List<Cliente> clientes = new List<Cliente>;

        public void CriaConta()
        {
            Console.WriteLine("Qual o tipo de conta, pessoa fisica(pf) ou pessoa juridica(pj)?");
            string tipoConta = Console.ReadLine();
            if (tipoConta == "pf") { }
            if (tipoConta == "pj") { }
            
            else  Console.WriteLine("Opção inválida"); 
        }

        public void CadastroPF()
        {
            //string nome, int numeroConta, string telefone, decimal saldo, string endereco, string cpf
            Console.WriteLine("Entre com os  dados do Cliente:");
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
        public void CadastroPJ() { }

        public void BuscaClientePorNumeroDeConta(int numeroConta)
        {
            
            foreach (var cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    Console.WriteLine(cliente.ToString());
                }
            }
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
