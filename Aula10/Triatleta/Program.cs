namespace Triatleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triatleta t1 = new Triatleta("Matheus");

            //usando os metodos das interfaces

            t1.Aquecer();
            t1.Correr();
            t1.Pedalar();
            t1.Nadar();
            t1.Cansou();
        }
    }
}