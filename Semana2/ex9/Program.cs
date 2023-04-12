namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            Console.WriteLine("Digite a quantidade de números para executar a média aritimética!");
            int qtd = int.Parse(Console.ReadLine());
            int[] numeros = new int[qtd];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write((i + 1) + " :");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach(int numero in numeros)
            {
                soma += numero;
            }
            Console.WriteLine("Média aritimética: "+(soma/qtd));
        }
    }
}