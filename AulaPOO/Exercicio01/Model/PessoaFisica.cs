using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaFisica : Cliente
    {
        private string impostoRenda;
        public PessoaFisica(int id, string nome, string cpf, string cel, string endereco, string impostoRenda) 
            : base(id, nome, cpf, cel, endereco)
        {
            this.impostoRenda = impostoRenda;
        }

        public string getImpostoRenda()
        {
            return this.impostoRenda;
        }

        public void SetImpostoRenda(string impostoRenda)
        {
            this.impostoRenda = impostoRenda;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Imposto de renda: {this.impostoRenda} ");
        }
    }
}
