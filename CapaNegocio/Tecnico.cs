using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tecnico : Empresa
    {
        private string apellidos;
        private string celular;
        private string especialidad;
        //Get-Set
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        //Metodos
        public string mantener()
        {
            return "El metodo mantener recien sera implementado";
        }
        public string ensamblar()
        {
            return "El metodo ensamblar recien sera implementado";
        }
        public string prevenir()
        {
            return "El metodo prevenir recien sera implementado";
        }
    }
}
