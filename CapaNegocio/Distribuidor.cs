using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Distribuidor : Empresa
    {
        private string celular;
        private string region;
        private string ruc;

        public string Celular { get => celular; set => celular = value; }
        public string Region { get => region; set => region = value; }
        public string Ruc { get => ruc; set => ruc = value; }

        public string Distribuir()
        {
            return "El metodo ordenar no ha sido implemntado";
        }
        public string Registrar()
        {
            return "El metodo supervisar no ha sido implemntado";
        }
        public string Asegurar()
        {
            return "El metodo ordenar no ha sido implemntado";
        }
    }
}
