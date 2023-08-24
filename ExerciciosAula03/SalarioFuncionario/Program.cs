namespace SalarioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? nome;
            int cargo;
            float salario, novoSal = 0;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();


            Console.WriteLine("   --------------- ");
            Console.WriteLine("1 | Gerente       |");
            Console.WriteLine("2 | Vendedor      |");
            Console.WriteLine("3 | Supervisor    |");
            Console.WriteLine("4 | Motorista     |");
            Console.WriteLine("5 | Estoquista    |");
            Console.WriteLine("6 | Tecnico de TI |");
            Console.WriteLine("   --------------- ");

            Console.WriteLine($"{nome} digite o seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nome} digite o seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    novoSal = salario + (salario * 0.10F);
                    break;

                case 2:
                    novoSal = salario + (salario * 0.07F);
                    break;
                case 3:
                    novoSal = salario + (salario * 0.09F);
                    break;
                case 4:
                    novoSal = salario + (salario * 0.06F);
                    break;
                case 5:
                    novoSal = salario + (salario * 0.05F);
                    break;
                case 6:
                    novoSal = salario + (salario * 0.08F);
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida..");
                    break;

            }
                    Console.WriteLine($"Nome do colaborador: {nome}");
                    Console.WriteLine($"Cargo: {cargo}");
                    Console.WriteLine($"Salário:: {novoSal}");
        }
    }
}