using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    //Chamando a herança da classe usando : e chamando a classe mãe(Transporte)
    public class Terrestre : Transporte
    {
        private int rodas;
        private int velocidade;
        //passando o construtor e herdando o metodo construtor da classe mãe ( :base(capacidade) )
        public Terrestre(int capacidade, int rodas, int velocidade) : base(capacidade) 
        {
            this.rodas = rodas;
            this.velocidade = velocidade;
        }

        //Getters e Setters

        public int GetRodas()
        {
            return rodas;
        }

        public void SetNumeroRodas(int rodas)
        {
            this.rodas = rodas;
        }

        public int GetVelocidade()
        {
            return velocidade;
        }

        public void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        //sobrescrevendo o metódo da classe mãe usando o (override)
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Número de rodas: {rodas}");
            Console.WriteLine($"Velocidade: {velocidade}");
        }
    }
}
