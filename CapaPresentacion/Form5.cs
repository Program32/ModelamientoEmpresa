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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Computadora computadora = new Computadora();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombre = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string ram = txtRam.Text.Trim();
            string procesador = txtProcesador.Text.Trim();
            string tarjetaVideo = txtTarjetaVideo.Text.Trim();

            // Escribir datos 
            computadora.Nombres = nombre;
            computadora.Direccion = direccion;
            computadora.Ram = ram;
            computadora.Procesador = procesador;
            computadora.TarjetaVideo = tarjetaVideo;

            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtDireccion.Clear();
            txtRam.Clear();
            txtProcesador.Clear();
            txtTarjetaVideo.Clear();

            // Hacer que el mouse este en el ram
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto 
            string nombres = computadora.Nombres;
            string direccion = computadora.Direccion;
            string ram = computadora.Ram;
            string procesador = computadora.Procesador;
            string tarjetaVideo = computadora.TarjetaVideo;

            MessageBox.Show("Datos de la computadora: " + "\n" + "Nombres: " + nombres + "\n" + "Direccion: " + direccion + "\n" + "ram: " + ram + "\n" +
                            "procesador: " + procesador + "\n" + "tarjetaVideo: " + tarjetaVideo + "\n");

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computadora.controlar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computadora.comprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computadora.orientar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computadora.informar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computadora.organizar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}

