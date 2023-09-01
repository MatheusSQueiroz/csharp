using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class Cliente
    {
        int id;
        private string nome = string.Empty;
        private string cpf = string.Empty;
        private string cel = string.Empty;
        private string endereco = string.Empty;

        public Cliente(int id, string nome, string cpf, string cel, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.cel = cel;
            this.endereco = endereco;
        }
        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetCPf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetCel()
        {
            return cel;
        }

        public void SetCel(string cel)
        {
            this.cel = cel;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public virtual void Visualizar()
        {
            string tipo = string.Empty;

            //Definição do tipo de cliente para exibir cpf ou cnpj
            switch (this.id)
            {
                case 1:
                    tipo = "Pessoa Física\nCPF do cliente: " + this.cpf;
                break;
                case 2:
                    tipo = "Pessoa Jurídica\nCNPJ do cliente: " + this.cpf;
                break;

            }
            Console.WriteLine("***************************************");
            Console.WriteLine("Dados do cliente:");
            Console.WriteLine("***************************************");
            Console.WriteLine("Nome do cliente: " + this.nome);          
            Console.WriteLine($"Tipo cliente: {tipo}");
            Console.WriteLine("Telefone do cliente: " + this.cel);
            Console.WriteLine("Endereço do cliente: " + this.endereco);
        }

    }

}
