namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int num = 0;



            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i]);

            }

            Console.WriteLine($"\nDigite um número:");
            num = Convert.ToInt32(Console.ReadLine());

            int posicao = Array.BinarySearch(vetor, num);

            if (posicao < vetor.Length)
            {

                Console.WriteLine($"\na posição do numero é:" + posicao);
            }
            else
            {
                Console.WriteLine($"\nNão foi encontrado!");
            }
        }
    }
}