using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Vendedor : Funcionario
    {
        private string loja = string.Empty;
        public Vendedor(string nome, int matricula, string cargo, string cpf, decimal salario, string loja) 
            : base(nome, matricula, cargo, cpf, salario)
        {
            this.loja = loja;
        }

        public string GetLoja()
        {
            return this.loja;
        }

        public void SetLoja(string loja)
        {
            this.loja = loja;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Loja atual: {this.loja}");
        }
    }
}
