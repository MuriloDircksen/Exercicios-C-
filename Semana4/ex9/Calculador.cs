using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    static class Calculador
    {
        public const decimal Pi= 3.14159265359M;
        
        
        public static Double Soma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        public static Double Subtrai(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public static Double Multiplica(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public static Double Dividi(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Divisão por zero!");
                return 0;
            }
            return valor1 / valor2;
        }
    }
}
