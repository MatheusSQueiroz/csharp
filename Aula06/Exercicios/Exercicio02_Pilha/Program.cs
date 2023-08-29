namespace Exercicio02_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            string? livro;

            Stack<string> pilha = new Stack<string>();

            do
            {

                Console.WriteLine("***************************************************");
                Console.WriteLine("         1 - Adicionar livro na pilha");
                Console.WriteLine("         2 - Listar todos os livros da pilha");
                Console.WriteLine("         3 - Retirar livro da pilha");
                Console.WriteLine("         0 - Sair");
                Console.WriteLine("***************************************************");
                Console.Write("             Entre com a opção desejada: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (option == 1)
                {
                    Console.Write("Digite o nome do livro: ");
                    livro = Console.ReadLine();
                    pilha.Push(livro);

                    Console.WriteLine("Pilha:");


                    foreach (var name in pilha)
                    {
                        Console.WriteLine(name);
                    }

                    Console.WriteLine("Livro adicionado!");

                }

                else if (option == 2)
                {
                    Console.WriteLine("Pilha:");

                    foreach (var name in pilha)
                    {
                        Console.WriteLine(name);
                    }
                }

                else if (option == 3)
                {
                    if (pilha.Count != 0)
                    {
                        pilha.Pop();

                        Console.WriteLine("Pilha:");

                        foreach (var name in pilha)
                        {
                            Console.WriteLine(name);
                        }
                        Console.WriteLine("O livro foi retirado!");
                    }
                    else
                    {
                        Console.WriteLine("A pilha está vazia!");
                    }
                }

            } while (option != 0);
            Console.WriteLine("Programa Finalizado!");
        }
    }
}