using Exercicio02.Model;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g1 = new Gerente ("Matheus", 18336, "Gerente", "40028922", 15000.00M, "SP");
            g1.Visualizar();

            Gerente g2 = new Gerente("Zézinho", 78965, "Gerente", "45875562", 16000.00M, "PB");
            g2.Visualizar();

            Vendedor v1 = new Vendedor("Buguinho", 12345, "Vendedor", "789456123", 5000.00M, "Matriz-RJ", 3);
            v1.Visualizar();

            Vendedor v2 = new Vendedor("Calleri", 00007, "Vendedor", "8782138", 6500.00M, "Aricanduva-SP", 4);
            v2.Visualizar();
        }
    }
}