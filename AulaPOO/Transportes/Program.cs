namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(5);

            t1.Visualizar();

            Console.WriteLine("\n");

            Terrestre t2 = new Terrestre(4, 4, 100);

            t2.Visualizar();
            Console.WriteLine("\n");

            Automovel a1 = new Automovel(5, 4, 120, "Preto", 4, "EQH3G06", 6);

            a1.Visualizar();



        }
    }
}