namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            //Adicionando elementos na fila
            fila.Enqueue("Matheus");
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Fulano");
            fila.Enqueue("Bugson");

            

            //Mostrar elementos
            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            //Tira o primeiro da fila
            fila.Dequeue();


            //Mostrar elementos
            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            //Mostra o primeiro da fila sem remover
            Console.WriteLine($"Quem é o primeiro da fila? {fila.Peek()}");

            //Verificar se existe o elemento e retornar true ou false
            Console.WriteLine($"O Fulano está na fila? {fila.Contains("Fulano")}");

            //Mostra o total de elemetos na lista
            Console.WriteLine($"Quantas pessoas tem na fila? {fila.Count}");

        }
    }
}