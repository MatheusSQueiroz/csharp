namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            //Adicionando elementos na fila
            pilha.Push("Matheus");
            pilha.Push("Ciclano");
            pilha.Push("Beltrano");
            pilha.Push("Fulano");
            pilha.Push("Bugson");



            //Mostrar elementos
            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            //Tira o ultimo da pilha
            pilha.Pop();


            //Mostrar elementos
            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            //Mostra o ultimo elemento da pilha
            Console.WriteLine($"Quem é o utlimo da pilha? {pilha.Peek()}");

            //Verificar se existe o elemento e retornar true ou false
            Console.WriteLine($"O Fulano faz parte da pilha? {pilha.Contains("Fulano")}");

            //Mostra o total de elemetos na lista
            Console.WriteLine($"Quantas pessoas tem na pilha? {pilha.Count}");

        }
    }
}