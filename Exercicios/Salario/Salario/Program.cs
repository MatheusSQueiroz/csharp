﻿namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digite o valor do salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;

            Console.WriteLine("Novo salário: " + Math.Round(novoSalario, 2));
        }
    }
}