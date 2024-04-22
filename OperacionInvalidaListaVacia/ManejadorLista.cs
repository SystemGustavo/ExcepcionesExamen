using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionInvalidaListaVacia
{
    public class ManejadorLista
    {
        private List<int> ListaEnteros = new List<int>();

        public List<int> GetListaEnteros() { return ListaEnteros; }

        public void EliminarElemento()
        {
            if (ListaEnteros.Count > 0)
            {
                ListaEnteros.RemoveAt(ListaEnteros.Count - 1);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

    }
}
