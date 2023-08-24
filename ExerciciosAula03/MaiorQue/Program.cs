namespace MaiorQue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA, numB, numC, resultado;

            Console.Write("Digite o número A: ");
            numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número B: ");
            numB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número C: ");
            numC = Convert.ToInt32(Console.ReadLine());

            if(numA + numB > numC ) {
                resultado = numA + numB;

                Console.WriteLine($"{numA} + {numB} = {resultado} > {numC}");
                Console.WriteLine("A soma de A + B é maior que C");
            }
             else if(numA + numB < numC ) {
                resultado = numA + numB;

                Console.WriteLine($"{numA} + {numB} = {resultado} < {numC}");
                Console.WriteLine("A soma de A + B é menor que C");
            }
            else if(numA + numB == numC ) {
                resultado = numA + numB;

                Console.WriteLine($"{numA} + {numB} = {resultado} = {numC}");
                Console.WriteLine("A soma de A + B é igual que C");
            }
        }
    }
}