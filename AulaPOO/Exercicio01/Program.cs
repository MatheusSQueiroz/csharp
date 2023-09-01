using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf1 = new PessoaFisica(1,"Matheus", "40028922","70707070", "Rua Sete", "Declarado" );
            pf1.Visualizar();
            
            PessoaFisica pf2 = new PessoaFisica(1, "Zézin", "7798416", "126165", "Rua Waldemar Tietz", "Pendente até 31/12/23");
            pf2.Visualizar();


            PessoaJuridica pj1 = new PessoaJuridica(2, "Devs S.A", "89224002", "12345678", "Rua Bugs", 789456123);
            pj1.Visualizar();

            PessoaJuridica pj2 = new PessoaJuridica(2, "Analistas S.A", "25542682", "40028922", "Rua PowerBI", 85785212);
            pj2.Visualizar();
        }
    }
}