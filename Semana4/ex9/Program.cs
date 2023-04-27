namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma 1 + 2: " + Calculador.Soma(1, 2));
            Console.WriteLine("Subtrair 1 - 2: " + Calculador.Subtrai(1, 2));
            Console.WriteLine("Multiplica 3 * 2: " + Calculador.Multiplica(3, 2));
            Console.WriteLine("Dividi 2 / 2: " + Calculador.Dividi(2, 2));
            Console.WriteLine("Dividi 2 / 0: " + Calculador.Dividi(2, 0));
        }
    }
}