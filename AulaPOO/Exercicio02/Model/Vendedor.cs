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
        private int comissao;
        public Vendedor(string nome, int matricula, string cargo, string cpf, 
            decimal salario, string loja, int comissao) 
            : base(nome, matricula, cargo, cpf, salario)
        {
            this.loja = loja;
            this.comissao = comissao;
        }

        public string GetLoja()
        {
            return this.loja;
        }

        public void SetLoja(string loja)
        {
            this.loja = loja;
        }

        public int GetComissao()
        {
            return this.comissao;
        }

        public void SetComissao(int comissao)
        {
            this.comissao = comissao;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Loja atual: {this.loja}");
            Console.WriteLine($"Porcentagem de comissão: {this.comissao}%");
        }
    }
}
