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
            set { _apellido = value; }
        }
        public int Edad
        {
        
            get {
                DateTime fechaActual = DateTime.Today;
                int edad = (fechaActual.Year - _fechaNac.Year);
                if(fechaActual.Month<_fechaNac.Month)
                {
                    --edad;
                }

                return edad; }
            
        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }            
        }

        // Metodos
        public virtual string GetCredencial()
        {
            string Credencial = _nombre + " " + _apellido;
            return Credencial;
        }

        public virtual string GetNombreCompleto()
        {

            string NombreCompleto = Nombre + " " + this._apellido;
            return NombreCompleto;

        }
        // Constructor
        public Persona(string apellido, DateTime fechaNac, string nombre)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;
        }
        public Persona()
        { }
    }
}
