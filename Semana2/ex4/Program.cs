namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a marca do veiculo!");
            String marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do veiculo!");
            String modelo = Console.ReadLine();
            Console.WriteLine("Digite o número de km rodados!");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("Veiculo de marca " + marca + ", modelo " + modelo);
            if (km >= 10000)
            {
                Console.WriteLine("Precisa fazer revisão!");
            }
        }
    }
}