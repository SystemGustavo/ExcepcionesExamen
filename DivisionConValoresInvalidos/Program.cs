public class Program
{
    public static int DividirNumeros(int numero1, int numero2)
    {
        if (numero1 < 0 || numero2 < 0)
        {
            throw new ArgumentException();
        }
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
            int res = DividirNumeros(numero1, numero2);
            Console.WriteLine($"\n{res}");
        }
        catch (ArgumentException)
        {
            Console.Write("Ambos números deben ser positivos para realizar la división");
        }
        finally
        {
            Console.ReadKey();
        }
    }
}