using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
        public class Transporte
        {
            private int capacidade;

            public Transporte(int capacidade)
            {
                this.capacidade = capacidade;
            }

            public int GetCapacidade()
            {
                return capacidade;
            }

            public void SetCapacidade(int capacidade)
            {
                this.capacidade = capacidade;
            }

            //Criando um metodo que poderá ser sobrescrito utilizando o (virtual)
            public virtual void Visualizar()
            {

                Console.WriteLine("\n\n************************************************************");
                Console.WriteLine("                Dados do Meio de Transporte:                    ");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("Capacidade de passageiros: " + this.capacidade);

            }
        }
}


