namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<string> nomes = new List<string>() {"Matheus S",
                "Bugson", 
                "Zézinho", 
                "Fulano", 
                "Ciclano", 
                "Matheus Q", 
                "Melissa", 
                "Duda", 
                "Junin", 
                "Zebug" 
            };

            var numerosAoCubo = numeros.Select(n => Math.Pow(n, 3));

            Console.WriteLine("Números elevados ao cubo: " + string.Join(", " ,numerosAoCubo));

            var numerosImpares = from numero in numeros
                                 where numero % 2 != 0
                                 select numero;

            Console.WriteLine("Números Ímpares: " + string.Join(", " ,numerosImpares));

            var nomesIniciamMZ = (from nome in nomes
                                 where nome.StartsWith('M') ||
                                       nome.StartsWith('Z')
                                select nome).ToList();

            nomesIniciamMZ.ForEach(n => Console.WriteLine(n));

           //Console.WriteLine("Nomes que iniciam com M ou Z: " + string.Join(", ", nomesIniciamMZ));


            var nomesContemC = from nome in nomes
                                 where nome.ToUpper().Contains('C')
                                 select nome;

            Console.WriteLine("Nomes que contém a letra C: " + string.Join(", ", nomesContemC));


            var numerosCrescente = from numero in numeros
                                 orderby numero
                                 select numero;

            Console.WriteLine("Números em ordem crescente: " + string.Join(", ", numerosCrescente));


            var numerosDecrescente = from numero in numeros
                                   orderby numero descending
                                   select numero;

            Console.WriteLine("Números em ordem Decrescente: " + string.Join(", ", numerosDecrescente));


            var nomesSemRepeticao = from nome in nomes
                               .Distinct()
                               select nome;

            Console.WriteLine("Nomes sem duplicidade: " + string.Join(", ", nomesSemRepeticao));


            var contarMatheus = nomes.Count(n => n.Contains("Matheus"));

            Console.WriteLine("Quantidade de Matheus na list: " + contarMatheus);
            
            
            var primeiroMatheus = nomes.First(n => n.Contains("Matheus"));

            Console.WriteLine("Primeiro Matheus da list: " + primeiroMatheus);
        }
    }
}