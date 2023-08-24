namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float numero1, numero2;

            Console.WriteLine("Digite o 1º número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            if (numero2 > 0){
                Console.WriteLine($"{numero1} / {numero2} = {(numero1 / numero2):F2}");
            }else
            {
                Console.WriteLine("O número " + numero1 +" não é possivel dividir por " + numero2);
            }

            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));
            Console.WriteLine($"Raiz quadrada de {numero1} = " + Math.Sqrt(numero1));
            Console.WriteLine($"Raiz quadrada de {numero2} = " + Math.Sqrt(numero2));
        }
    }
}