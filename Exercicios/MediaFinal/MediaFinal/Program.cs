namespace MediaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media1, media2, media3, media4, mediaFinal;

            Console.WriteLine("Digite a primeira média: ");
            media1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a segunda média: ");
            media2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a terceira média: ");
            media3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a quarta média: ");
            media4 = Convert.ToSingle(Console.ReadLine());

            mediaFinal = (media1 + media2 + media3 + media4) / 4;

            Console.WriteLine("Média final: " + Math.Round(mediaFinal, 2));
        }
    }
}