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
