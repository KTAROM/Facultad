using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
   public class Bedel:Empleado
    {
        private string _apodo;

        // Propiedades
        public string Apodo
        {
            get { return _apodo; }
        }

        //Metodos
        public string GetNombreCompleto()
        {
            string nombreCompleto = "";
            return nombreCompleto;
        }
    }
}
