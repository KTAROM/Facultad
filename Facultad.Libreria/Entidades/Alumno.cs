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
        private string _nombre;
        private string _apellido;

        // Propiedades
        public int Codigo
        {
            get { return _codigo; }
        }
        public string Credencial
        {
            get { return Credencial; }
        }

        // Constructor
        public Alumno(string apellido, DateTime fechaNac, string nombre, int codigo) :
            base(apellido, fechaNac, nombre)
        {
            this._apellido = apellido;
            this._codigo = codigo;
            this._nombre = nombre;
            this._fechaNac = fechaNac;

        }
        public Alumno()
        { }
        // Metodos
       public override string GetCredencial()
        {//ALTERNATIVA
            //string.Format("Codigo {0},{1},{2}", this._codigo, this._nombre, this._apellido);
            string Credencial = "Código " + this._codigo + " ) " + this._apellido+" " + this._nombre;
          
                return Credencial;
        }
        public string ToString()
        {
            return GetCredencial();
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            else return false;

        }
    }
}
