using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA3_01
{
    class Nodo
    {
        public Nodo siguiente;
        public Nodo anterior;

        public string nombre;

        public Nodo (string nom)
        {
            siguiente = null;
            anterior = null;
            nombre = nom;
        }

        //get y set para el siguiente
        public Nodo getSiguiente()
        {
            return siguiente;
        }
        public void setSiguiente(Nodo set)
        {
            siguiente = set;
        }

        //get y set para el anterior
        public Nodo getAnterior()
        {
            return anterior;
        }
        public void setAterior(Nodo ant)
        {
            anterior = ant;
        }

    }
}
