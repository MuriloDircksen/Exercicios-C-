namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numero = 0;
            do
            {
                Console.WriteLine("Digite um número positivo!");
                numero = int.Parse(Console.ReadLine());
                if(numero > 0)
                {
                    break;
                }
                Console.WriteLine("Erro, número inválido digitado");

            } while (true);

            Console.WriteLine("Números pares:");

            for(int i = 0; i < numero; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}