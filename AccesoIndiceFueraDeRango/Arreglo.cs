using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoIndiceFueraDeRango
{
    public class Arreglo
    {
        private int[] arreglo;

        // Constructor

        public void IniciarArregloEnteros(int num)
        {
            arreglo = new int[num];
        }

        public int[] arregloEnteros()
        {
            return arreglo;
        }

        public int ObtenerElemento(int indice)
        {
            if (indice < 0 || indice >= arreglo.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return arreglo[indice];
        }
    }
}
