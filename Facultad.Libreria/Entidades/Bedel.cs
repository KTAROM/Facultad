using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
  class Bedel:Empleado
    {
        private string _apodo;

        // Propiedades
        public string Apodo
        {
            get { return _apodo; }
        }

        //Metodos
        
        public override string GetNombreCompleto()
        {

            string NombreCompleto = "Bedel " + Apodo;
            return NombreCompleto;

        }
        public Bedel(string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo, string apodo) :
            base(apellido, fechaNac, nombre, fechaingreso, legajo)
        { }
    }
}
