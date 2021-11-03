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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Tecnico tecnico = new Tecnico();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();

            tecnico.Nombres = nombres;
            tecnico.Direccion = direccion;
            tecnico.Apellidos = apellidos;
            tecnico.Celular = celular;
            tecnico.Especialidad = especialidad;

            MessageBox.Show("Se ha escrito correctamente en el objeto");

            txtNombres.Clear();
            txtDireccion.Clear();
            txtApellidos.Clear();
            txtCelular.Clear();
            txtEspecialidad.Clear();

            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = tecnico.Nombres;
            string direccion = tecnico.Direccion;
            string apellidos = tecnico.Apellidos;
            string celular = tecnico.Celular;
            string especialidad = tecnico.Especialidad;
            MessageBox.Show("Datos del tecnico" + "\n" + "Nombres: " + nombres + "\n" + "Direccion: " + direccion + "\n" + "Apellidos: " + apellidos +
                            "\n" + "Celular: " + celular + "\n" + "Especialidad: " + especialidad + "\n");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.controlar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.comprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.mantener());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.ensamblar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.prevenir());
        }
    }
}
