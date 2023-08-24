using System.Linq.Expressions;

namespace Lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProduto, qtdProd;
            decimal valorTotal = 0;
            String produto = "";

            Console.WriteLine("  ---------------------------- ");
            Console.WriteLine("1 | Cachorro Quente | R$10.00 |");
            Console.WriteLine("2 | X-Salada        | R$10.00 |");
            Console.WriteLine("3 | X-Bacon         | R$18.00 |");
            Console.WriteLine("4 | Bauru           | R$12.00 |");
            Console.WriteLine("5 | Refrigerante    | R$8.00  |");
            Console.WriteLine("6 | Suco de Laranja | R$13.00 |");
            Console.WriteLine("  ---------------------------- ");
            Console.Write("Digite o código do produto: ");
            codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de produtos: ");
            qtdProd = Convert.ToInt32(Console.ReadLine());

            switch (codigoProduto)
            {
                case 1:
                    produto = "Cachorro Quente";
                    valorTotal = qtdProd * 10;
                    break;

                case 2:
                    produto = "X-Salada";
                    valorTotal = qtdProd * 10;
                    break;
                case 3:
                    produto = "X-Bacon";
                    valorTotal = qtdProd * 18;
                    break;
                case 4:
                    produto = "Bauru";
                    valorTotal = qtdProd * 12;
                    break;
                case 5:
                    produto = "Refrigerante";
                    valorTotal = qtdProd * 8;
                    break;
                case 6:
                    produto = "Suco de Laranja  ";
                    valorTotal = qtdProd * 13;
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }

            Console.WriteLine($"O valor total é R$: {valorTotal}");
            Console.WriteLine($"Produto: {produto}");

        }
    }
}