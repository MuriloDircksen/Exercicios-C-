namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros!");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma deles é: "+ (n1+n2));
        }
    }
}