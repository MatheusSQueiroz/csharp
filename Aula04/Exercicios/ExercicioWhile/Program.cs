namespace ExercicioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? continua = "S";
            int backend = 0, mulherCisTransFront =0 , homemCisTransM40 = 0, naoBiFull = 0, total = 0,
                media = 0, idade = 0, identidadeGen = 0, dev, somaIdades = 0;


            while (continua.Equals("S"))
            {


            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua identidade e genêro: ");
            Console.WriteLine("1 - Mulher Cis");
            Console.WriteLine("2 - Homem Cis");
            Console.WriteLine("3 - Não Binário");
            Console.WriteLine("4 - Mulher Trans");
            Console.WriteLine("5 - Homem Trans");
            Console.WriteLine("6 - Outros");
            identidadeGen = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Você é uma pessoa desenvolvedora: ");
            Console.WriteLine("1 - Backend ");
            Console.WriteLine("2 - Frontend ");
            Console.WriteLine("3 - Mobile ");
            Console.WriteLine("4 - Fullstack ");
            dev = Convert.ToInt32(Console.ReadLine());

                if(dev == 1)
                {
                    backend += 1;
                } 
                if((identidadeGen ==1 || identidadeGen ==4) && dev == 2 )
                {
                    mulherCisTransFront += 1;
                } 
                if((identidadeGen == 2 || identidadeGen == 5) && dev == 3 && idade > 40)
                {
                    homemCisTransM40 += 1;
                }
                if(identidadeGen ==3 && dev == 4 && idade < 30)
                {
                    naoBiFull += 1;
                }

                total++;

                somaIdades += idade;
               
             Console.WriteLine("Deseja continuar? [S] [N]");
             continua = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($"Total de pessoas desenvolvedoras Backend: {backend}");
            Console.WriteLine($"Total de Mulheres Cis e Trans desenvolvedoras Frontend: " +
                $"{mulherCisTransFront}");
            Console.WriteLine($"Total de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos:" +
                $" {homemCisTransM40}");
            Console.WriteLine($"Total de Pessoas Não Binárias desenvolvedoras FullStack menores de 30 anos:" +
                $" {naoBiFull}");
            Console.WriteLine($"O número total de pessoas que responderam à pesquisa {total}");
            Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa: {somaIdades / total}");



        }
    }
}