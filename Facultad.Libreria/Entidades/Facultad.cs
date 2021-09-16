using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Facultad1
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
        public void AgregarAlumno(string apellido, DateTime fechaNac, string nombre, int codigo)
        {
            Alumno Alumno1 = new Alumno (apellido, fechaNac, nombre, codigo);
            _Alumnos.Add(Alumno1);
        }

        private void AgregarEmpleado(Empleado Empleado1)
        {
            _Empleados.Add(Empleado1);
        }
        private void AgregarEmpleado(string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo)
        {
            Empleado Empleado1 = new Empleado(nombre, fechaNac, apellido, fechaingreso, legajo);
            _Empleados.Add(Empleado1);
        }

        public void EliminarAlumno(int c)
        {
            foreach (Alumno alum in _Alumnos)
            {
                if (alum.Codigo.Equals(c))
                {
                    _Alumnos.Remove(alum);
                }
            }
        }

        public void EliminarEmpleado(int e)
        {
            foreach (Empleado emp in _Empleados)
            {
                if (emp.Legajo.Equals(e))
                {
                    _Empleados.Remove(emp);
                }
            }
           
        }

        private void ModificarEmpleado(Empleado Empleado1)
        {

        }
        public List<Alumno> TraerAlumnos()
        {
            return _Alumnos;
        }

       /* private Empleado TraerEmpleadoPorLegajo( int e)
        {
            Empleado empleado = new Empleado();
            foreach( Empleado empl in _Empleados)
            {
                if (empl.Legajo == e)
                { empleado = empl; }
            }
            return empleado;
        }*/

        private List<Empleado> TraerEmpleados()
        {
            return _Empleados;
        }

       /* public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            return _Empleados;
        }*/
       public Facultad1 (string Nombre)
        {

        }
    }
}
