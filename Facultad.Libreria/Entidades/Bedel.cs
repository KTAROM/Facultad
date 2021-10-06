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
            set { this._apodo = value; }
            get { return this._apodo; }
        }

        //Metodos
        
        public override string GetNombreCompleto()
        {

            string NombreCompleto = "Bedel " + this._apodo;
            return NombreCompleto;

        }
        public override string ToString()
        {
            return GetNombreCompleto();
        }
        public Bedel(string apellido, DateTime fechaNac, string nombre, DateTime fechaingreso, int legajo, string apodo) :
            base(apellido, fechaNac, nombre, fechaingreso, legajo)
        {
            this._apodo = apodo;
        }
    }
}
