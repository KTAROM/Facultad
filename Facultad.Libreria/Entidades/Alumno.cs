using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Alumno: Persona(string apellido, DateTime fechaNac, string nombre)
    {
        private int _codigo;

        // Propiedades
        public int Codigo
        {
            get { return _codigo; }
        }
        public string Credencial
        {
            get {  return }
        }

        // Metodos

    }
}
