using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaJuridica : Cliente
    {
        private int numContratoSocial;
        public PessoaJuridica(int id, string nome, string cpf, string cel, string endereco, int numContratoSocial) 
            : base(id, nome, cpf, cel, endereco)
        {
            this.numContratoSocial = numContratoSocial;
        }

        public int GetNumContratoSocial()
        {
            return numContratoSocial;
        }

        public void SetNumContratoSocial(int numContratoSocial)
        {
            this.numContratoSocial = numContratoSocial;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine($"Número do contrato social: {numContratoSocial}");
        }
    }
}
