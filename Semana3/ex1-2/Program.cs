namespace ex1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma número 2 e 3: " + Soma(2, 3));
            Console.WriteLine("Soma número 2,3 e 3,2: " + Soma(2.3, 3.2));
            Console.WriteLine("Soma número 2,3, 3,2 e 4,1: " + Soma(2.3, 3.2, 4.1));
        }

        static int Soma(int n1, int n2) {
            return n1 + n2;
        }

        static double Soma(double n1, double n2) {  return n1 + n2; }

        static double Soma(double n1, double n2, double n3) { return n1 + n2 + n3; }
    }
}