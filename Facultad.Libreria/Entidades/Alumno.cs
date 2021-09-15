using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Alumno: Persona
    {
        private int _codigo;

        // Propiedades
        public int Codigo
        {
            get { return _codigo; }
        }
        public string Credencial
        {
            get { return Credencial; }
        }

        // Metodos
        public Alumno(string apellido, DateTime fechaNac, string nombre, int codigo): 
            base(apellido, fechaNac, nombre)
        {

        }
    }
}
