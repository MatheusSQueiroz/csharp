using System.Globalization;

namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, continua = "S";
            int idade, esporte, futebol = 0, voleibolMaior18 = 0, baquetebolMenor18 = 0;

            do
            {

                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();
                
                Console.Write("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.Write("Digite o seu esporte favorito\n");
                    Console.Write("1 - Futebol | 2- Volei | 3- Basquete | 4- Outros: ");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                Console.Write("Deseja continuar? S ou N: ");
                continua = Console.ReadLine().ToUpper();

                if(esporte == 1)
                {
                    futebol++;
                }

                if(esporte == 2 && idade > 18)
                {
                    voleibolMaior18++;
                }

                if (esporte == 3 && idade < 18)
                {
                    baquetebolMenor18++;
                }

            } while (continua.Equals("S"));

            Console.WriteLine($"Pessoas que gostam de Futebol: {futebol}");
            Console.WriteLine($"Pessoas que gostam de Voleibol maior de 18: {voleibolMaior18}");
            Console.WriteLine($"Pessoas que gostam de Basquete menor de 18: {baquetebolMenor18}");
        }
    }
}