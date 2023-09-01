using Exercicio02.Model;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g1 = new Gerente ("Matheus", 18336, "Gerente", "40028922", 15000.00M, "SP");
            g1.Visualizar();

            Vendedor v1 = new Vendedor("Buguinho", 12345, "Vendedor", "789456123", 5000.00M, "Matriz-RJ");
            v1.Visualizar();
        }
    }
}