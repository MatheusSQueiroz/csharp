namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int somaPrincipal = 0, somaSecundaria = 0;
            string diagonalPrincipal = "", diagonalSecundaria = "";



            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz.Length); indiceColuna++)
                {
                    Console.Write($"Matriz[{indiceLinha} , {indiceColuna}] = ");
                    matriz[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int indice = 0; indice < Math.Sqrt(matriz.Length); indice++)
            {
                diagonalPrincipal += matriz[indice, indice] + " ";
                somaPrincipal += matriz[indice, indice];
            }

            for (int indice = 0; indice < Math.Sqrt(matriz.Length); indice++)
            {
                diagonalSecundaria += matriz[indice, (int)(Math.Sqrt(matriz.Length) - 1 - indice)] + "";
                somaSecundaria += matriz[indice, (int)(Math.Sqrt(matriz.Length) - 1 - indice)];
            }

            Console.WriteLine($"Elementos da diagonal principal {diagonalPrincipal}");
            Console.WriteLine($"Soma dos elementos da diagonal principal {somaPrincipal}");

            Console.WriteLine($"Elementos da diagonal secundária {diagonalSecundaria}");
            Console.WriteLine($"Soma dos elementos da diagonal secundária {somaSecundaria}");
        }
    }
}