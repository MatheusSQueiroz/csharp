namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite o primeiro número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 0 &&  num %2== 0)
            {
                Console.WriteLine($"O número {num} é positivo e par");
            } 
            else if(num < 0 &&  num %2!= 0)
            {
                Console.WriteLine($"O número {num} é negativo e ímpar");
            }
            else if(num < 0 &&  num %2== 0)
            {
                Console.WriteLine($"O número {num} é negativo e par");
            }
            else if(num > 0 && num %2!= 0)
            {
                Console.WriteLine($"O número {num} é positivo e ímpar");
            }
        }
    }
}