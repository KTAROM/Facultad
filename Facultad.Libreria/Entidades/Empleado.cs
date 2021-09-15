using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    abstract class Empleado:Persona
    {
        private DateTime _fechaingreso;
        private int _legajo;
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
            get { return _fechaingreso; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNac; }
        }

        public int Legajo
        {
            get { return _legajo; }
        }

        public List<Salario> Salarios
        {
            get { return _salarios; }
        }

        public Salario UltimoSalario
        {
            
            get { return _salarios.Last(); }
        }

        // Constructor
        public Empleado(string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo): 
            base(apellido, fechaNac, nombre)
        { }
    }
}
