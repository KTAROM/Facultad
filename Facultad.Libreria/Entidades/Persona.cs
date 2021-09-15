using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Persona
    {
        private string _apellido;
        public DateTime _fechaNac;
        private string _nombre;

        // Propiedades
        public string Apellido
        {
            get { return _apellido; }
        }
        /*public int Edad
        {
        
            get { return int.Parse(DateTime.Today - _fechaNac); }
        }*/

        public string Nombre
        {
            get { return _nombre; }
        }

        // Metodos
        public string GetCredencial()
        {
            string Credencial = Nombre + " " + Apellido;
            return Credencial;
        }

        public string GetNombreCompleto()
        {

            string NombreCompleto = Nombre + " " + Apellido;
            return NombreCompleto;

        }
        // Constructor
        public Persona(string apellido, DateTime fechaNac, string nombre)
        {
            
        }
    }
}
