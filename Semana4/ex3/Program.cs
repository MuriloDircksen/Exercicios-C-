namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Joao Silva", "123.456.789-00");
            ContaBancaria contaBancaria = new ContaBancaria(1234, cliente);


            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria.ExibirDados());

            contaBancaria.Depositar(1000.00);
            Console.WriteLine("Deposito de R$ 1000,00");

            Console.WriteLine(contaBancaria.ToString());

            contaBancaria.Saca(500.00);
            Console.WriteLine("Saque de R$ 500,00");

            Console.WriteLine(contaBancaria.ToString());
        }
    }
}