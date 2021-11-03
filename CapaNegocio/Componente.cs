using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Componente : Empresa
    {
        private string precio;
        private string codigoBarras;
        //Get-Set
        public string Precio { get => precio; set => precio = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }

        //Declaracion de metodo
        public string procesar()
        {
            return "El metodo procesar recien sera implementado";
        }
        public string efectuar()
        {
            return "El metodo efectuar recien sera implementado";
        }
        public string almacenar()
        {
            return "El metodo almacenar recien sera implementado";
        }
    }
}
