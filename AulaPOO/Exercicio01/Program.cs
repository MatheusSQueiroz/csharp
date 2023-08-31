using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente (123, "Matheus", "40028922", "70707070", "Rua Sete");
            Cliente c2 = new Cliente(456, "Zé Bug", "12345678", "49227872", "Rua Error 404");
          
            c1.Visualizar();
            c2.Visualizar();
        }
    }
}