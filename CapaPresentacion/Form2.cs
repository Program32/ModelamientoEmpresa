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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        JefeAlmacen jefeAlmacen = new JefeAlmacen();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombres = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string edad = txtEdad.Text.Trim();

            // Escribir datos del Alumno en el objeto
            jefeAlmacen.Nombres = nombres;
            jefeAlmacen.Direccion = direccion;
            jefeAlmacen.Apellidos = apellidos;
            jefeAlmacen.Celular = celular;
            jefeAlmacen.Edad = edad;

            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtDireccion.Clear();
            txtApellidos.Clear();
            txtCelular.Clear();
            txtEdad.Clear();

            // Hacer que el mouse este en el apellido
            txtApellidos.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propuiedades del objeto 
            string nombres = jefeAlmacen.Nombres;
            string direccion = jefeAlmacen.Direccion;
            string apellidos = jefeAlmacen.Apellidos;
            string celular = jefeAlmacen.Celular;
            string edad = jefeAlmacen.Edad;

            MessageBox.Show("Datos del Alumno: " + "\n" + "Nombres: " + nombres + "\n" + "Direccion: " + direccion + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Celular: " + celular + "\n" + "Edad: " + edad + "\n");

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.controlar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.comprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Ordenar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Supervisar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Coordinar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
