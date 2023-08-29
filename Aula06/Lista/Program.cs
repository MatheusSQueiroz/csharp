namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <double> notas = new List <double>();

            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            //Mostrar todos os elementos da lista
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
            //Mostrar a posição do elemento solicitado
            Console.WriteLine($"Posição da Nota 4: {notas.IndexOf(4.0)}");
            //Verificar se existe o elemento e retornar true ou false
            Console.WriteLine($"A Nota 4 existe? {notas.Contains(4.0)}");
            //Remover o elemento
            notas.Remove(4.0);

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine($"Posição da Nota 10: {notas.IndexOf(10.0)}");

            //Mostra o total de elemetos na lista
            Console.WriteLine($"Quantos elementos tem a lista? {notas.Count}");

            //Ordenar os elementos em ordem crescente
            notas.Sort();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("----------"); ;

            //Ordena os elementos em ordem descrescente
            notas.Reverse();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("----------");

            //Alterar um elemento da lista pelo indice dele
            notas[1] = 9.3;

            //Utiliza o VAR para identificar o tipo da variavel declarada
            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }

        }
    }
}