namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collection HashSet que não deixa elementos serem repetidos
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Fulano",
                "Ciclano",
                "Beltrano",
                "Matheus",
                "Fulano",
                "Ciclano"

            };

            //Mostrando os elementos
            foreach(var nome in setNomes) 
            { 
                Console.WriteLine(nome);
            }
            
            //Adicionando elementos
            setNomes.Add("Bugson");
            setNomes.Add(null);
            setNomes.Add("Zézinho");

            //Mostrando os elementos
            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            //Verificar se existe o elemento e retornar true ou false
            Console.WriteLine($"O nome bugson existe? {setNomes.Contains("Bugson")}");
            
            //Remover o element
            setNomes.Remove("Ciclano");

            //Mostrando os elementos
            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }


            //Ordenando a lista
            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in hashList)
            {
                Console.WriteLine(hash);
            }
        }
    }
}