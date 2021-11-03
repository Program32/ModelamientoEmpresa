using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Empresa
    {
        //Declaracion de atributos
        private string nombres;
        private string direccion;
        //Propiedades para los atributos
        //Propiedades de lectura GET-GETTER
        //Propiedades de escritura SET-SETTER
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        //Declaracion de metodos y operaciones
        public string controlar()
        {
            return "El metodo controlar recien sera implementado";
        }
        public string comprobar()
        {
            return "El metodo comprobar recien sera implementado";
        }
    }
}
