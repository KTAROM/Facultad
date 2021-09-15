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
            get { return _fechaingreso; }
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
            
            get { return _salarios.Last<Salario>; }
        }
    }
}
