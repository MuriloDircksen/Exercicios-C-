using System.Diagnostics;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char variavel = 'a';
            double n1 = 0, n2 = 0;
           
            do
            {
                Console.WriteLine("Escolha a operação a ser executada:\n+: Soma\n-: Subtração\n*: Multiplicação\n/: Divisão\n?: Sair ");
                variavel = char.Parse(Console.ReadLine());
                bool controle = true;
                double resultado = 0;
                if (variavel != '?')
                {
                    
                    Console.WriteLine("Digite o primeiro número do calculo");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número do calculo");
                    n2 = int.Parse(Console.ReadLine());
               
                    switch (variavel)
                    {
                        case '+':
                            resultado = n1 + n2;
                            break;
                        case '-':
                            resultado = n1 - n2;
                            break;
                        case '*':
                            resultado = n1 * n2;
                            break;
                        case '/':
                            if (n2 == 0)
                            {
                                Console.WriteLine("Não é possível dividir por zero!");
                                break;
                            }
                            resultado = n1 / n2;
                            break;
                        case '?':
                        
                            break;
                        default:
                            Console.WriteLine("Insira um valor correto!");
                            controle = false;
                            break;

                    }
                    if (controle)
                    {
                        Console.WriteLine($"Resultado: {resultado}\n\n");
                    }
                }
            } while (variavel != '?');
            Console.WriteLine("Obrigado por usar a Calculadora!");
        }
    }
}