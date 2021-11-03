using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Computadora :  Empresa
    {
        private string ram;
        private string procesador;
        private string tarjetaVideo;

        public string Ram { get => ram; set => ram = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string TarjetaVideo { get => tarjetaVideo; set => tarjetaVideo = value; }

        public string orientar()
        {
            return "El metodo orientar no ha sido implemntado";
        }
        public string informar()
        {
            return "El metodo informar no ha sido implemntado";
        }
        public string organizar()
        {
            return "El metodo organizar no ha sido implemntado";
        }
    }
}
