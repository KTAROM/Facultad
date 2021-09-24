using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Directivo: Empleado
    {
        public override string GetNombreCompleto()
        {

            string NombreCompleto = "Sr. Director " + Apellido;
            return NombreCompleto;

        }
        public override string ToString()
        {
            return GetNombreCompleto();
        }
        public Directivo (string apellido, DateTime fechaNac, string nombre, DateTime fechaingreso, int legajo) :
            base(apellido, fechaNac, nombre, fechaingreso, legajo)
        { }

    }
}
