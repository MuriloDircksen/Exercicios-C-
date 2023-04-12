namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int numero = 0;
            Console.WriteLine("Digite cinco números!");
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write((i+1)+" :");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] > numero)
                {
                    numero = numeros[i];
                }
            }
            Console.WriteLine("Maior número: " + numero);
            
        }
    }
}