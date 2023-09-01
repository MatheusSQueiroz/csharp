using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf1 = new PessoaFisica(1,"Matheus", "40028922","70707070", "Rua Sete", "Declarado" );
            pf1.Visualizar();
            Console.WriteLine("\n");

            PessoaJuridica pj1 = new PessoaJuridica(2, "Devs S.A", "89224002", "12345678", "Rua Bugs", 789456123);
            pj1.Visualizar();
        }
    }
}