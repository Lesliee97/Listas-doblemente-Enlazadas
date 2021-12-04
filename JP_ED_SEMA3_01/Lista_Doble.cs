using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_ED_SEMA3_01
{
    class Lista_Doble
    {
        //declaramos las varibles de tipo nodo
        public Nodo primero;
        public Nodo ultimo;
        public Nodo aux;

        //crear el constructor
        public Lista_Doble()
        {
            primero = null;
            ultimo = null;
            aux = null;
        }

        //crear el metodo para crear los nodos
        public void insertar (string nom)
        {
            if(primero == null)
            {
                Nodo nuevo = new Nodo(nom);
                primero = nuevo; //se crear el primer nodo
                ultimo = primero; //el nuevo nodo para a ser el ultimo
            }
            else
            {
                Nodo nuevo = new Nodo(nom);
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void imprimir(DataGridView L)
        {
            L.Rows.Clear();
            Nodo p = primero;
            while (p != null)
            {
                L.Rows.Add(p.nombre);
                p = p.siguiente;
            }
        }
    }
}
