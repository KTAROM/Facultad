using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Facultad
    {
        private List<Alumno> _Alumnos;
        private int _cantidadSedes;
        private List<Empleado> _Empleados;
        private string _nombre;

        // Propiedades
        public int CantidadSedes
        {
            get { return _cantidadSedes; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        // Metodos
        public void AgregarAlumno(Alumno Alumno1)
        {
            _Alumnos.Add(Alumno1);
        }

        public void AgregarEmpleado(Empleado Empleado1)
        {
            _Empleados.Add(Empleado1);
        }

        public void EliminarAlumno(int c)
        {
            _Alumnos.Remove(c);
        }

        public void EliminarEmpleado(int e)
        {
            _Empleados.Remove(e);
        }

        public void ModificarEmpleado(Empleado Empleado1)
        {

        }
        public List<Alumno> TraerAlumnos()
        {
            return ListaAlumnos;
        }

        public Empleado TraerEmpleadoPorLegajo( int e)
        {

            foreach( Empleado c in _Empleados)
            {

            }
            return;
        }

        public List<Empleado> TraerEmpleados()
        {
            return _Empleados;
        }

        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            return _Empleados;
        }

    }
}
