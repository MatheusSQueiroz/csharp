namespace DiferencaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, diferenca;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            n4 = float.Parse(Console.ReadLine());

            diferenca = (n1 * n2) - (n3 * n4);

            Console.WriteLine("Diferença: " + Math.Round(diferenca, 1));
        }
    }
}