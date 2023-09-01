using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos02.Namespace01
{
    public class Classe02
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe 02");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe  02");
        }

        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protected - Classe  02");
        }

        private static void MetodoPrivate()
        {
            Console.WriteLine("Método Private - Classe  02");
        }
    }
}
