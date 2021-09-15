using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    class Directivo: Empleado
    {
        public Directivo (string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo) :
            base(apellido, fechaNac, nombre, fechaingreso, legajo)
        { }

    }
}
