namespace Exercio3While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, menor21 = 0, maior50 = 0;

            while (idade >= 0) 
            { 
            Console.Write("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

                if(idade >= 0)
                    {

                    if (idade < 21)
                    {
                        menor21++;
                    }

                    if (idade > 50)
                    {
                        maior50++;
                    }
               
                
                    }
                }

            Console.WriteLine($"Total de pessoas com menos de 21 anos: {menor21}");
            Console.WriteLine($"Total de pessoas com mais de 50 anos: {maior50}");
        }
    }
}