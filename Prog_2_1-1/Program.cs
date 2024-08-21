using Prog_2_1_1;

class Program
{
    public static void Main()
    {
        Pila pila = new Pila();

        Console.WriteLine(pila.estaVacia());
        Console.WriteLine("----------------------");
        Console.Write("");

        for(int i = 0;i <= 10; i++)
        {
            Console.WriteLine(pila.añadir());
        }
        Console.WriteLine("----------------------");
        Console.Write("");

        Console.WriteLine(pila.estaVacia());
        Console.WriteLine("----------------------");
        Console.Write("");

        Console.WriteLine(pila.primero());
        Console.WriteLine("----------------------");
        Console.Write("");


        Console.WriteLine(pila.Elementos.Length);
        Console.WriteLine(pila.extraer());
        Console.WriteLine("----------------------");
        Console.Write("");

        Console.WriteLine(pila.Elementos.Length);
        Console.WriteLine("----------------------");
        Console.Write("");
    }
}