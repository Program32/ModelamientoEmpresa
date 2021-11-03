using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Componente componente = new Componente();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string nombres = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string precio = txtPrecio.Text.Trim();
            string codigoBarras = txtcodigoBarras.Text.Trim();
            //Escribir datos del componente en el objeto
            componente.Nombres = nombres;
            componente.Direccion = direccion;
            componente.Precio = precio;
            componente.CodigoBarras = codigoBarras;
            //Confirmar que se ha escrito el mensaje
            MessageBox.Show("Se ha escrito el objeto correctamente");
            //Limpiar las cajas de texto
            txtNombres.Clear();
            txtDireccion.Clear();
            txtPrecio.Clear();
            txtcodigoBarras.Clear();
            //Hacer que el mause este en nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = componente.Nombres;
            string direccion = componente.Direccion;
            string precio = componente.Precio;
            string codigoBarras = componente.CodigoBarras;
            MessageBox.Show("Datos del componente: " + "\n" + "Nombres: " + nombres + "\n" + "Direccion: " + direccion + "\n" + "Precio: " + precio +
                            "\n" + "Codigo de Barras: " + codigoBarras + "\n");        
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.controlar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.comprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.procesar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.efectuar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.almacenar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
