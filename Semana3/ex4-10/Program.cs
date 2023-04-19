using ex4_10.models;
using System.Reflection.PortableExecutable;

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

            var carro1 = new Carro()
            {
                Marca = "Fiat",
                Modelo = "Palio 1.0",
                Placa = "GTY6431",
                Cor="Azul",
                Proprietario = proprietario1
            };

            var carro2 = new Carro()
            {
                Marca = "Fiat",
                Modelo = "Uno Mille",
                Placa = "LWG9570",
                Cor = "Vermelho",
                Proprietario = proprietario2
            };

            var carro3 = new Carro()
            {
                Marca = "Volkswagen",
                Modelo = "Fusca 78",
                Placa = "FNW7297",
                Cor = "Bege",
                Proprietario = proprietario3
            };

            var Carros = new List<Carro>();
            Carros.Add(carro1);
            Carros.Add(carro2);
            Carros.Add(carro3);
        }
    }
}