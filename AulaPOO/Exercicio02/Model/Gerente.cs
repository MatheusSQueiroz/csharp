using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Gerente : Funcionario
    {
        private string regional = string.Empty;

        public Gerente(string nome, int matricula, string cargo, string cpf, decimal salario, string regional)
            : base(nome, matricula, cargo, cpf, salario)
        {
            this.regional = regional;
        }

        public string GetRegional() 
        { 
            return this.regional; 
        }

        public void SetRegional(string regional)
        {
            this.regional = regional;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Regional atual: {this.regional}");
        }
    }
}
