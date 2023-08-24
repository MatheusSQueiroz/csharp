namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;

            Console.Write("Digite a 1ª nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a 2ª nota: ");
            nota2= Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2) / 2;


            /* 
             if ternario
             O que se encontra antes do ? é a condição 
             O que se encontra depois do : é a mensagem da negação da condição
            */

            Console.WriteLine((media >= 6) ? "Aprovado!" : "Reprovado!" );
                            // condição?    ação verdade: ação para falso
        }
    }
}