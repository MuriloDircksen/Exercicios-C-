using FullStackBank.Services;

namespace FullStackBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            ClienteService _clienteService = new ClienteService();
            do
            {
                Console.WriteLine("Bem vindo ao FullStack Bank, escolha uma opção para continuar:");
                Console.WriteLine("1 - Abrir Conta");
                Console.WriteLine("2 - Consultar Conta");
                Console.WriteLine("3 - Listar todas as Contas");                
                Console.WriteLine("4 - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        _clienteService.CriarConta();
                        break;
                    case "2":
                        Console.WriteLine("Qual numero de conta deseja consultar?");
                        _clienteService.BuscarClientePorNumeroDeConta(int.Parse(Console.ReadLine()));
                        break;
                    case "3":
                        _clienteService.ExibirClientes();
                        break;
                    case "4":                                             
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("\n");
            } while (opcao != "6");
           
        }
    }
}