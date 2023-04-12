namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase!");
            String frase = Console.ReadLine();
            String[] palavras = frase.Split(" ");

            foreach(String palavra in palavras)
            {
                if(palavra == "poderosa")
                {
                    Console.WriteLine(palavra);
                }
            }
        }
    }
}