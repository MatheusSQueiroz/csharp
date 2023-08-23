namespace Diferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;

            Console.WriteLine("Digite o salário bruto: ");
            salarioBruto = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o adicional noturno: ");
            adicionalNoturno = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas extras: ");
            horasExtras = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite os descontos: ");
            descontos = float.Parse(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;

            Console.WriteLine("Salário liquído: " + Math.Round(salarioLiquido, 2));
        }
    }
}