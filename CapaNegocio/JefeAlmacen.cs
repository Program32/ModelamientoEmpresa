using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefeAlmacen : Empresa
    {
        private string apellidos;
        private string celular;
        private string edad;

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Edad { get => edad; set => edad = value; }

        public string Ordenar()
        {
            return "El metodo ordenar no ha sido implemntado";
        }
        public string Supervisar()
        {
            return "El metodo supervisar no ha sido implemntado";
        }
        public string Coordinar()
        {
            return "El metodo ordenar no ha sido implemntado";
        }

    }
}
