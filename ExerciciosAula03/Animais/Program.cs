namespace Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? caracteristica1, caracteristica2, caracteristica3;

            Console.WriteLine("Digite a primeira característica");
            caracteristica1 = Console.ReadLine();
            
            Console.WriteLine("Digite a segunda característica");
            caracteristica2 = Console.ReadLine(); 

            Console.WriteLine("Digite a terceira característica");
            caracteristica3 = Console.ReadLine();

            if (caracteristica1 is not null && caracteristica2 is not null && caracteristica3 is not null)
            {
                //Verificando se é vertebrado ou invertebrado
                if (caracteristica1.Equals("vertebrado"))
                {
                    //Verificando se é ave ou mamifero
                    if (caracteristica2.Equals("ave"))
                    {
                        if (caracteristica3.Equals("carnivoro"))
                        {
                            Console.WriteLine("Águia.");
                        }
                        else
                        {
                            Console.WriteLine("Pomba.");
                        }
                    }
                    else
                    {
                        if (caracteristica3.Equals("onivoro"))
                        {
                            Console.WriteLine("Homem.");
                        }
                        else
                        {
                            Console.WriteLine("Vaca.");
                        }
                    }
                }
                else
                {

                    //Verificando se é inseto ou anelídeo
                    if (caracteristica2.Equals("inseto"))
                    {
                        if (caracteristica3.Equals("hematofago"))
                        {
                            Console.WriteLine("Pulga.");
                        }
                        else
                        {
                            Console.WriteLine("Lagarta.");
                        }
                    }
                    else
                    {
                        if (caracteristica3.Equals("onivoro"))
                        {
                            Console.WriteLine("Minhoca.");
                        }
                        else
                        {
                            Console.WriteLine("Sanguessuga.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("As característica não podem ser nulas!!");
            }
        }
    }
}