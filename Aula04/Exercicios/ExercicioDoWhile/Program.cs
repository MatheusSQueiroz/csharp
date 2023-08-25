namespace ExercicioDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, somaPositivo = 0;

            do
            {
                Console.Write("Digite o número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num > 0)
                {
                    somaPositivo += num;
                }

            
            }while(num != 0);

                Console.WriteLine($"A soma dos números positivos é: {somaPositivo}");
        }
    }
}