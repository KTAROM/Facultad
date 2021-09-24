using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Empleado:Persona
    {
        private DateTime _fechaingreso;
        private int _legajo;
        private Salario _ultimoSalario;
        List<Salario> _salarios;

        // Propiedades
        public int Antiguedad
        {
            get {
                DateTime fechaActual = DateTime.Today;
                int Antiguedad = (fechaActual.Year - _fechaingreso.Year);
                if(_fechaNac.Month>fechaActual.Month)
                {
                    --Antiguedad;
                }
                return Antiguedad; }
        }

        public DateTime FechaIngreso
        {
            get { return this._fechaingreso; }
        }

        public DateTime FechaNacimiento
        {
            get { return this._fechaNac; }
        }

        public int Legajo
        {
            get { return this._legajo; }
        }

        public List<Salario> Salarios
        {
            get { return this._salarios; }
        }

        public Salario UltimoSalario()
        {
            
           return this._ultimoSalario; 
        }
        public override string GetCredencial()
        {
            string Credencial = this._legajo+" " + GetNombreCompleto() + " salario " + UltimoSalario();
            return Credencial;
        }
        public virtual string ToString()
        {
            return GetCredencial();
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            else return false;
           
        }
        // Constructor
        public Empleado(string apellido, DateTime fechaNac, string nombre, DateTime fechaingreso, int legajo): 
            base(apellido, fechaNac, nombre)
        {
            this._fechaNac = fechaNac;
            this._legajo = legajo;
            this._fechaingreso = fechaingreso;
            
        }
        public Empleado()
        { }
    }
}
