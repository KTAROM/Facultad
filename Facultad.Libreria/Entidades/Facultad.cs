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
            AgregarAlumno(Alumno1);
        }

        public void AgregarEmpleado(Empleado Empleado1)
        {
            _Empleados.Add(Empleado1);
        }
        public void AgregarEmpleado(string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo)
        {
            Empleado Empleado1 = new Empleado(nombre, fechaNac, apellido, fechaingreso, legajo);
            AgregarEmpleado(Empleado1);
        }

        public void EliminarAlumno(int c)
        {
            
            bool existe = false;
            Alumno alumno1 = new Alumno();
           
            if (_Alumnos.Count() != 0)
            {
                foreach (Alumno alumno in _Alumnos)
                {

                    if (alumno.Codigo.Equals(c))
                    {
                        alumno1 = alumno;
                        existe = true;
                       
                    }
                   
                }
                if (existe)
                { _Alumnos.Remove(alumno1);
                    Console.WriteLine("El alumno ha sido eliminado");
                }
                else { Console.WriteLine("El código ingresado no existe, intente nuevamente"); }
            }

            else { Console.WriteLine("Aún no se han ingresado empleados");    }
            Console.ReadKey();


        }

        public void EliminarEmpleado(int e)
        {
            bool existe = false;
            Empleado Empleado1 = new Empleado();

            if (_Empleados.Count() != 0)
            {
                foreach (Empleado empleado in _Empleados)
                {

                    if (empleado.Legajo.Equals(e))
                    {
                        Empleado1 = empleado;
                        existe = true;

                    }

                }
                if (existe)
                {
                    _Empleados.Remove(Empleado1);
                    Console.WriteLine("El empleado ha sido eliminado");
                }
                else { Console.WriteLine("El legajo ingresado no existe, intente nuevamente"); }
            }

            else { Console.WriteLine("Aún no se han ingresado alumnos"); }
            Console.ReadKey();



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

       public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
       foreach (Empleado empl in _Empleados)
       {
                if(empl.Nombre==nombre)
                {

                }
       }
            return _Empleados;
        }
       public Facultad1 (string Nombre)
        {// creo las listas para evitar null, ahora son vacias
            this._nombre = Nombre;
            this._Alumnos = new List<Alumno>();
            this._Empleados = new List<Empleado>();
        }
    }
}
