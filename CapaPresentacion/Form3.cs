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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        TrabajadorCounter trabajadorCounter = new TrabajadorCounter();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            trabajadorCounter.Nombres = nombres;
            trabajadorCounter.Direccion = direccion;
            trabajadorCounter.Apellidos = apellidos;
            trabajadorCounter.Dni = dni;
            trabajadorCounter.Correo = correo;


            MessageBox.Show("Se ha escrito correctamente en el objeto");

            txtNombres.Clear();
            txtDireccion.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtCorreo.Clear();


            txtNombres.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = trabajadorCounter.Nombres;
            string direccion = trabajadorCounter.Direccion;
            string apellidos = trabajadorCounter.Apellidos;
            string dni = trabajadorCounter.Dni;
            string correo = trabajadorCounter.Correo;

            MessageBox.Show("Datos del TrabajadorCounter: " + "\n" + "Nombres: " + nombres + "\n" + "Direccion: " + direccion + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Dni: " + dni + "\n" + "Correo: " + correo + "\n");

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajadorCounter.controlar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajadorCounter.comprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajadorCounter.Recepcionar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajadorCounter.Entregar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajadorCounter.Informar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
