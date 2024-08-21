using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_1_1
{
    internal class Cola : ICollecion
    {
        public int contador { get; set; }
        List<Object> lista;

        public Cola()
        {
            this.lista = new List<object>();
        }
        public bool añadir()
        {
            lista.Insert(0, contador);
            contador++;
            return true;
            
        }

        public bool estaVacia()
        {
            if (lista.Count > 0)
            {
                return false;
            }
            return true;
        }

        public object extraer()
        {
            object elemento = lista[0];
            lista.RemoveAt(0);
            return elemento;
        }

        public object primero()
        {
            return lista[0];
        }
    }
}
