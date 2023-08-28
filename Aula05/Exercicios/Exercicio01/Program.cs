namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInt = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int num;

            Array.Sort(vetorInt);

            Console.Write("Digite um número para ser encontrado no vetor: ");
            num = Convert.ToInt32(Console.ReadLine());

               int posicao = Array.BinarySearch(vetorInt, num);

            if (posicao >= 0)
                Console.WriteLine($"O número {num} está localizado na posição {posicao}");

            else
                Console.WriteLine($"O número {num} não foi encontrado");

        }
    }
}