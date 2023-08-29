namespace Exercicio01_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();


            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Digite uma cor: ");
                cores.Add(Console.ReadLine());

            }
                
                Console.WriteLine("Todas as cores:");
            
                foreach (var cor in cores)
                {
                    Console.WriteLine(cor);
                }

                cores.Sort();

                Console.WriteLine("Cores ordenadas:");

                foreach (var cor in cores)
                {
                    Console.WriteLine(cor);
                }
        }
    }
}