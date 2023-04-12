namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 números inteiros!");
            int[] numeros = new int[4];

            for(int i = 0; i < 4; i++) {
                Console.WriteLine($"Digite o numero {i+1}");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);

            Console.WriteLine("Números ordenados:");
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}