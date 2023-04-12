namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do paciente!");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do paciente!");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do paciente: " + nome);

            if (idade < 18) { 
                Console.WriteLine("Menor de idade: " +  idade + " anos");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("Idoso");
                Console.WriteLine("Maior de idade: " + idade + " anos");
            }
            else
            {
                Console.WriteLine("Maior de idade: " + idade + " anos"); 
            }
        }
    }
}