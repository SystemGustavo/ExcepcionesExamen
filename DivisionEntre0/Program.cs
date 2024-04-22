public class Program
{
    public static int Dividir(int numero1, int numero2)
    {
        return numero1 / numero2;
    }

    public static void Main()
    {

        Console.WriteLine("Ingrese el 1er Numero");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el 2do Numero");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            int res = Dividir(numero1, numero2);
            Console.WriteLine($"\n{res}");
        }
        catch (DivideByZeroException)
        {
            Console.Write("La Division entre 0 No Esta Permitida");
        }
        finally
        {
            Console.ReadKey();
        }
    }
}

