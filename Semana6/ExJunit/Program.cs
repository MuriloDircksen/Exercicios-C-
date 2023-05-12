namespace ExJunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 7, -3, 4, 6 };
            List<int> order = Calculator.Order(list);
            order.ForEach(x => { Console.WriteLine(x); });
        }
    }
}