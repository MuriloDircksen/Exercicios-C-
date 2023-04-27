namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ContaBancaria contaBancaria = new ContaBancaria();

            contaBancaria.Depostio(1000.00M);
            Console.WriteLine("Saldo: " + contaBancaria.ConsultaSaldo());
            contaBancaria.Saque(1200.00M);
            Console.WriteLine("Saldo: " + contaBancaria.ConsultaSaldo());
            contaBancaria.Saque(300.00M);
            Console.WriteLine("Saldo: " + contaBancaria.ConsultaSaldo());
            contaBancaria.Depostio(100.00M);
            Console.WriteLine("Saldo: " + contaBancaria.ConsultaSaldo());
            Console.WriteLine();
            contaBancaria.HistoricoTransacoes();
        }
    }
}