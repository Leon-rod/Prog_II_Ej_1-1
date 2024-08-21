using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_1_1
{
    internal class Pila : ICollecion
    {
        public Object[] Elementos { get; set; }
        public int Contador { get; set; }

        public Pila()
        {
            this.Elementos = new Object[10];
            this.Contador = 0;
        }


        public bool añadir()
        {
            Object obj = new object();
            obj = Contador;
            bool flag = false;
            if (Contador < 10)
            {
                flag = true;
                Elementos[Contador] = obj;
                Contador++;
            }
            return flag;
        }

        public bool estaVacia()
        {
            if(Contador == 0)
            {
                return true;
            }
            return false;
        }

        public object extraer()
        {
            if (Contador != 0)
            {
                Object ultimoElemento = Elementos[Contador-1];
                Array.Clear(Elementos, Contador-1, 1);
                Contador--;
                return ultimoElemento;
            }
            Object objetoVacio = new object();
            return objetoVacio;
        }

        public object primero()
        {
            if (Elementos.Any())
            {
                return Elementos[0];
            }
            Object elementoVacio = new object();
            return elementoVacio;
        }
    }
}
