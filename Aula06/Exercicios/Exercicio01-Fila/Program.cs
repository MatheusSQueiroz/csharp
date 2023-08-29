namespace Exercicio01_Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            string? nome;

            Queue<string> fila = new Queue<string>();

            do
            {

                Console.WriteLine("***************************************************");
                Console.WriteLine("         1 - Adicionar cliente na fila");
                Console.WriteLine("         2 - Listar todos os clientes");
                Console.WriteLine("         3 - Retirar cliente da fila");
                Console.WriteLine("         0 - Sair");
                Console.WriteLine("***************************************************");
                Console.Write("             Entre com a opção desejada: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (option == 1)
                {
                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();
                    fila.Enqueue(nome);

                    Console.WriteLine("Fila:");


                    foreach (var name in fila)
                    {
                        Console.WriteLine(name);
                    }

                    Console.WriteLine("Cliente adicionado!");

                }

                else if (option == 2)
                {
                    Console.WriteLine("Fila:");

                    foreach (var name in fila)
                    {
                        Console.WriteLine(name);
                    }
                }

                else if (option == 3)
                {
                    if (fila.Count != 0)
                    {
                        fila.Dequeue();

                        Console.WriteLine("Fila:");

                        foreach (var name in fila)
                        {
                            Console.WriteLine(name);
                        }
                        Console.WriteLine("O cliente foi chamado!");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia!");
                    }
                }
              
            } while (option != 0);
            Console.WriteLine("Programa Finalizado!");
        }
    }
}