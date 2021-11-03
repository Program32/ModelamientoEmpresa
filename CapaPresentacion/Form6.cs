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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Distribuidor distribuidor = new Distribuidor();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombres = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string region = txtRegion.Text.Trim();
            string ruc = txtRuc.Text.Trim();

            // Escribir datos del Alumno en el objeto
            distribuidor.Nombres = nombres;
            distribuidor.Direccion = direccion;
            distribuidor.Celular = celular;
            distribuidor.Region = region;
            distribuidor.Ruc = ruc;

            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtRegion.Clear();
            txtRuc.Clear();

            // Hacer que el mouse este en el celular
            txtNombres.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propuiedades del objeto
            string nombres = distribuidor.Nombres;
            string direccion = distribuidor.Direccion;
            string celular = distribuidor.Celular;
            string region = distribuidor.Region;
            string ruc = distribuidor.Ruc;

            MessageBox.Show("Datos del Distribuidor: " + "\n" + "Nombres: " + nombres + "\n" + "Direccion: " + direccion + "\n" + "Celular: " + celular + "\n" + "Region: " + region + 
                            "\n" + "Ruc: " + ruc + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.controlar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.comprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Distribuir());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Registrar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Asegurar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
