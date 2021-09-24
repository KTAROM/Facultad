using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Docente: Empleado
    {
        public override string GetNombreCompleto()
        {

            string NombreCompleto = "Docente " + Nombre;
            return NombreCompleto;

        }
        public override string ToString()
        {
            return GetNombreCompleto();
        }
        // Constructor
        public Docente (string apellido, DateTime fechaNac, string nombre, DateTime fechaingreso, int legajo) :
            base(apellido, fechaNac, nombre, fechaingreso, legajo)
                { }

    }
}
