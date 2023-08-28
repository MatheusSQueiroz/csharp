namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor02 = new int[5];

            string[] vetor03 = { "Matheus", "Ciclano", "Beltrano", "Fulano", "Zezinho", "Bugson" };

            for(int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine($"vetor01 [{indice}] = {vetor01[indice]}");
            }

            Console.WriteLine("\n");
            
            for(int indice = 0; indice < 5; indice++)
            {
                Console.Write($"vetor01 [{indice}] = ");
                vetor02[indice] = Convert.ToInt32(Console.ReadLine());
            } 

            Console.WriteLine("\n");

            //ordenar o vetor em ordem crescente
            Array.Sort(vetor02);
            
            for(int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.WriteLine($"vetor02 [{indice}] = {vetor02[indice]}");
            }

            Console.WriteLine("\n");

            //ordenar o vetor em ordem decrescente
            Array.Reverse(vetor02);

            for(int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.WriteLine($"vetor02 [{indice}] = {vetor02[indice]}");
            }

            Console.WriteLine("\n");


            //ordenar o vetor em ordem crescente
            Array.Sort(vetor03);
            
            for(int indice = 0; indice < vetor03.Length; indice++)
            {
                Console.WriteLine($"vetor02 [{indice}] = {vetor03[indice]}");
            }
        }
    }
}