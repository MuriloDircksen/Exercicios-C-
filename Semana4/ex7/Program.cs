namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Saldo = 10.00;
            Console.WriteLine("Deposito de 1000");
            contaBancaria.Depositar(1000.00) ;
            contaBancaria.Depositar(500.00);
            Console.WriteLine("Deposito de 500");
            Console.WriteLine("Saldo: " + contaBancaria.Saldo);
            Console.WriteLine("Saque de 100");
            contaBancaria.Sacar(100.00);
            Console.WriteLine("Saldo: " + contaBancaria.Saldo);
        }
    }
}