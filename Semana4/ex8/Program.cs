namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("dog", 1);
            Gato gato = new Gato("lib", 1);

            cachorro.EmitirSom();
            gato.EmitirSom();



        }
    }
}