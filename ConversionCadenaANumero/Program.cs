public class Program
{
    public static void ConvertirNumero(string cadena)
    {
        int.Parse(cadena);
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese una cadena");
        try
        {
            ConvertirNumero(Console.ReadLine());
            Console.WriteLine("Conversion Exitosa ..!!");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nla cadena no puede ser convertida a un entero ..!! Conversion Invalida ");
            Console.ReadKey();
        }
        Console.ReadKey();
    }
}