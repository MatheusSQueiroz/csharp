namespace ExercicioFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 < num2)
            {
                for(num1 = 0; num1 <= num2; num1++)
                {

                    if(num1 > 0 && num1 % 3 == 0 && num1 % 5 == 0)
                    {
                        Console.WriteLine($"\n{num1} é múltiplo de 3 e 5");
                    }
                }
            }
            else
            {
                Console.WriteLine("Intervalo inválido!");
            }

            }
            
        }
    }
