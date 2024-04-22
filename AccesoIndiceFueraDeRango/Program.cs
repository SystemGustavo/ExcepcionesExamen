using AccesoIndiceFueraDeRango;

public class Program
{

    public static void Main()
    {
        Arreglo objArreglo = new Arreglo(); ;
        string opcion;
        do
        {
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine("A = Agregar Indice");
            Console.WriteLine("O = Obtener Indice");
            Console.WriteLine("S = Salir del Programa");
            Console.Write("Opcion => ");
            opcion = Console.ReadLine();
            try
            {
                if (opcion.ToUpper() == "A")
                {
                    Console.WriteLine(" ***  Agregando Numeros al arreglo  ***");
                    Console.Write("numero de elementos => ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    objArreglo.IniciarArregloEnteros(numero);
                    for (int i = 0; i < objArreglo.arregloEnteros().Length; i++)
                    {
                        Console.WriteLine($"Ingrese el numero para llenar el indice {i} del arreglo => ");
                        int numeros = int.Parse(Console.ReadLine());
                        objArreglo.arregloEnteros()[i] = numeros;
                    }
                    //Console.WriteLine($"El numero {numero} ha sido Agregado al arreglo \n");
                }
                else if (opcion.ToUpper() == "O")
                {
                    Console.WriteLine("\n ***  Obteniendo Indice del Arreglo ***");
                    Console.Write("Ingrese un Indice =>");
                    int indiceNumero = int.Parse(Console.ReadLine());
                    objArreglo.ObtenerElemento(indiceNumero);
                    Console.WriteLine($" *** Indice Obtenido {objArreglo.ObtenerElemento(indiceNumero)}  ***\n");
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
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("El Indice está fuera de los límites del arreglo ..!!\n");
            }
        } while (opcion is string);
        Console.ReadKey();
    }
}
