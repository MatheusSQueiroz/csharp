namespace Exercicio03_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> num = new HashSet<int>();

            for(int i = 1; i <= 10; i++) 
            {
                Console.Write("Digite uma número: ");
                num.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Dados do HashSet:");

            foreach (var numeros in num)
            {
                Console.WriteLine(numeros);
            }
        }
    }
}