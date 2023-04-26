namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo
            {
                Altura = -1,
                Largura = 2,
            };
            Retangulo retangulo2 = new Retangulo { 
                Altura= 5,
                Largura = 2,
            };

            Console.WriteLine("Area: "+ retangulo1.CalculaArea());
            Console.WriteLine("Area: " + retangulo2.CalculaArea());
        }
    }
}