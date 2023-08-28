namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matrizNotas = new float[10,4];

            float[] vetorMedia = new float[10];



            for (int lin = 0; lin < matrizNotas.GetLength(0); lin++)
            {
                for(int col = 0; col < matrizNotas.GetLength(1); col++)
                {


                Console.WriteLine($"Digite as notas para a posição [{lin}] [{col}]:");
                matrizNotas[lin, col] = Convert.ToSingle(Console.ReadLine());

                }
                
            }

            for (int lin = 0; lin < matrizNotas.GetLength(0); lin++)
            {
                for (int col = 0; col < matrizNotas.GetLength(1); col++)
                {
                    vetorMedia[lin] += matrizNotas[lin, col];
                }

                vetorMedia[lin] = vetorMedia[lin] / 4;
            }

            for(int lin = 0; lin < matrizNotas.GetLength(0); lin++)
            {
                Console.WriteLine($"A média é: {vetorMedia[lin]:F1}");
            }
        }
    }
}