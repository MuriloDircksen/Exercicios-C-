namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Joana", 23, "Rua das flores"); 
            Console.WriteLine(pessoa1.Saudacao());
        }
    }
}