namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria(-200.00);
            Console.WriteLine(contaBancaria.Saldo.ToString("C"));
            contaBancaria.Depositar(100.00);
            Console.WriteLine(contaBancaria.Saldo.ToString("C"));
            Console.WriteLine(contaBancaria.Sacar(100.00));
            Console.WriteLine(contaBancaria.Saldo.ToString("C"));
            
        }
    }
}