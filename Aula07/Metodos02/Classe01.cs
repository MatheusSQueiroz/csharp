using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos02
{
    public class Classe01
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe 01");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe  01");
        }

        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protected - Classe  01");
        }

        private static void MetodoPrivate()
        {
            Console.WriteLine("Método Private - Classe  01");
        }
    }
}
