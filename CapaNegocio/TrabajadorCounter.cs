using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TrabajadorCounter : Empresa
    {
        private string apellidos;
        private string dni;
        private string correo;

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Correo { get => correo; set => correo = value; }

        public string Recepcionar()
        {
            return "El metodo recepcionar no ha sido implementado";
        }
        public string Entregar()
        {
            return "El metodo entregar no ha sido implementado";
        }
        public string Informar()
        {
            return "El metodo informar no ha sido implementado";
        }

    }
}
