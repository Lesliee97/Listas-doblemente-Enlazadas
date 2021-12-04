using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_ED_SEMA3_01
{
    public partial class Form1 : Form
    {
        Lista_Doble lista = new Lista_Doble();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            lista.insertar(Convert.ToString(txtNombre.Text));
            txtNombre.Text = "";
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            lista.aux = lista.primero;
            while(lista.aux !=null)
            {
                listLista.Items.Add(Convert.ToString(lista.aux.nombre));
                lista.aux = lista.aux.siguiente; //apunta el nodo siguiente
                lista.imprimir(dgvLista);
            } // dgvLista.Rows.Add

            lista.aux = lista.ultimo;
            while (lista.aux != null)
            {
                listLista.Items.Add(Convert.ToString(lista.aux.nombre));
                lista.aux = lista.aux.anterior; //apunta el nodo anterior
            }
        }
    }
}
