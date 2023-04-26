namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Joao";
            pessoa.Idade = -1;
            Console.WriteLine(pessoa.Idade);
            pessoa.DefinirIdade(10);
            Console.WriteLine(pessoa.Idade);
        }
    }
}