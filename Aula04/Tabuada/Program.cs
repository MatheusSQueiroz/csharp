namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Write("Digite qual tabuada deseja: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // utilizando laço For

            for(int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero}  x {contador} =  {numero * contador}");
            }
        }
    }
}