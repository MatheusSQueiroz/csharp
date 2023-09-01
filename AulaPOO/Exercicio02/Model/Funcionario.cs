using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Funcionario
    {
        private string nome = string.Empty;
        private int matricula;
        private string cargo = string.Empty;
        private string cpf = string.Empty;
        private decimal salario;

        public Funcionario(string nome, int matricula, string cargo, string cpf, decimal salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cargo = cargo;
            this.cpf = cpf;
            this.salario = salario;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetMatricula()
        {
            return matricula;
        }

        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public string GetCargo()
        {
            return cargo;
        }

        public void SetCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCel(string cel)
        {
            this.cpf = cpf;
        }

        public decimal GetSalario()
        {
            return salario;
        }

        public void SetSalario(decimal salario)
        {
            this.salario = salario;
        }

        public virtual void Visualizar()
        {
         
           

            Console.WriteLine("***************************************");
            Console.WriteLine("Dados do funcionário:");
            Console.WriteLine("***************************************");
            Console.WriteLine("Nome do funcionário: " + this.nome);
            Console.WriteLine("Matricula do funcionário: " + this.matricula);
            Console.WriteLine("CPF do funcionário: " + this.cpf);
            Console.WriteLine("Cargo do funcionário: " + this.cargo);
            Console.WriteLine("Salário do funcionário: " + this.salario);
        }

    }

}
