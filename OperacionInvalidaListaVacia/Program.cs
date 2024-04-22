using OperacionInvalidaListaVacia;

public class Program
{

    public static void Main()
    {
        ManejadorLista objManejador = new ManejadorLista(); ;
        string opcion;
        do
        {
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine("A = Agregar");
            Console.WriteLine("E = Eliminar");
            Console.WriteLine("S = Salir del Programa");
            Console.Write("Opcion => ");
            opcion = Console.ReadLine();
            try
            {
                if (opcion.ToUpper() == "A")
                {
                    Console.WriteLine(" ***  Agregando Numeros a la Lista  ***");
                    Console.WriteLine("Escriba el Numero : ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    objManejador.GetListaEnteros().Add(numero);
                    Console.WriteLine($"El numero {numero} ha sido Agregado a la lista\n");
                }
                else if (opcion.ToUpper() == "E")
                {
                    Console.WriteLine(" ***  Eliminando ultimo numero de la Lista  ***");
                    objManejador.EliminarElemento();
                    Console.WriteLine(" *** Ultimo Elemento de la Lista Eliminado  ***\n");
                }
                else if (opcion.ToUpper() == "S")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Opcion Invalida\n");
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No se Puede Eliminar un elemento de la lista vacia ..!!\n");
            }
        } while (opcion is string);
        Console.ReadKey();
    }
}
