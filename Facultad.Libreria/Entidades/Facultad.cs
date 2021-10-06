using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.ConsolaUtils1;
using Facultad.ExceptionNoHayAlumno;
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
           this._Alumnos.Add(Alumno1);
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
            Salario ultSalario = new Salario(DateTime.Today);
            Empleado Empleado1 = new Empleado(nombre, fechaNac, apellido, fechaingreso, legajo);
            Empleado1.UltimoSalario = ultSalario;
            AgregarEmpleado(Empleado1);
        }

        public void EliminarAlumno(int c)
        {
            List<Alumno> ListaAlum = this._Alumnos;

            if (ListaAlum.Count() == 0)
            {
                throw new ExceptionNoHayAlumnos();
            }
            else
            {
                foreach (Alumno d in ListaAlum)
                {
                    if (d.Codigo.Equals(c))
                    { this._Alumnos.Remove(d); }
                    else
                    {
                        ConsolaUtils.MsjErr("El Alumno ingresado no existe");
                        Console.ReadKey();
                    }
                }
            }
                
        }

        // Alumno alumno2 = this._Alumnos.Find(x => x.Equals(new Alumno(c)));
        /* else { this._Alumnos.Remove(alumno1); }*/

    

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
                    ConsolaUtils.MsjErr("El empleado ha sido eliminado");
                }
                else 
                { ConsolaUtils.MsjErr();
                    Console.ReadKey();
                }
            }

            else { ConsolaUtils.MsjErr("Aún no se han ingresado empleados"); }
            Console.ReadKey();



        }

        private void ModificarEmpleado(Empleado Empleado1)
        {

        }
        public List<Alumno> TraerAlumnos()
        {
            if (this._Alumnos.Count() == 0)
            {
                throw new ExceptionNoHayAlumnos();
            }
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

        public List<Empleado> TraerEmpleados()
        {
            if (this._Empleados.Count() == 0)
            {
                throw new ExceptionNoHayAlumnos();
            }
            return _Empleados;
        }

       public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            List<Empleado> EmplPorNom = new List<Empleado>();
            List<Empleado> TodosEmpl = TraerEmpleados();
           
       foreach (Empleado empl in TodosEmpl)
       {
                if(empl.Nombre.Equals(nombre))
                {
                    EmplPorNom.Add(empl);
                }
       }
            return EmplPorNom;
        }
       public Facultad1 (string Nombre)
        {// creo las listas para evitar null, ahora son vacias
            this._nombre = Nombre;
            this._Alumnos = new List<Alumno>();
            this._Empleados = new List<Empleado>();
        }
    }
}
