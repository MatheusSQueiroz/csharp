using Exercicio02.Model;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Matheus", 18336, "Desenvolvedor Jr", "40028922", 15000.00M);
            Funcionario f2 = new Funcionario("Zé Bug", 15208, "TechLead", "89224002", 30000.00M);

            f1.Visualizar();
            f2.Visualizar();
        }
    }
}