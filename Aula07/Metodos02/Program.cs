using Metodos02.Namespace01;

namespace Metodos02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chamando metodos internos
            MetodoInternal();
            MetodoPublico();
            MetodoProtected();
            MetodoPrivate();

            //Chamando metodos externos
            Classe01.MetodoPublico();
            Classe01.MetodoInternal();

            //Chamando metodos externos
            Classe02.MetodoPublico();
            Classe02.MetodoInternal();
            Classe02.
            
        }

        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe program");
        }
        
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe program");
        }
        
        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protected - Classe program");
        }
        
        private static void MetodoPrivate()
        {
            Console.WriteLine("Método Private - Classe program");
        }
    }
}