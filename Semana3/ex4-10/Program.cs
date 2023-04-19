using ex4_10.models;

namespace ex4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var proprietario1 = new Proprietario();
          
           
            proprietario1.Nome = "Vladimir Moraes";
            proprietario1.Cpf = "222.359.780-70";
            proprietario1.Telefone = "48987356723";

            var proprietario2 = new Proprietario()
            {
                Nome = "Joao Silva",
                Cpf = "977.181.500-89",
                Telefone = "48983546733"

            };

            var proprietario3 = new Proprietario()
            {
                Nome = "Joana Cabral",
                Cpf = "811.715.540-01",
                Telefone = "48983345443"

            };

        }
    }
}