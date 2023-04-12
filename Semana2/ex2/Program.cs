namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro!");
            int n = int.Parse(Console.ReadLine());

            if(n%2 == 0)
            {
                Console.WriteLine("Número par digitado!");
            }
            else
            {
                Console.WriteLine("Número ímpar digitado!");
            }
        }
    }
}