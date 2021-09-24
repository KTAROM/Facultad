using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria.Entidades;
using Facultad.ConsolaUtils;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool opcion = true;
            string eleccion;
            Facultad1 Economicas = new Facultad1("FCE");
            Console.WriteLine("Bienvenidos a " + Economicas.Nombre + "\n");
            do
            {               
                Menu();
                eleccion = Console.ReadLine();
                switch (eleccion.ToUpper())
                {
                    case "1":
                        AgregarAlumno(Economicas);
                        break;
                    case "2":
                        AgregarEmpleado(Economicas);
                        break;
                    case "3":
                        EliminarAlumno(Economicas);
                        break;
                    case "4":
                        EliminarEmpleado(Economicas);
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "s":
                        break;
                    default:
                        Console.WriteLine("La opción ingresada es incorrecta!!!");
                        opcion = false;
                        break;

                }
                Console.Clear();
                
            } while (opcion == true);
        }

        public static void Menu()
        {
            Console.WriteLine(
              "Ingrese la opción deseada:" + "\n" +
              "1- Agregar un nuevo Alumno" + "\n" +
              "2- Agregar un nuevo Empleado" + "\n" +
              "3- Eliminar un alumno existente" + "\n" +
              "4- Eliminar un empleado existente" + "\n" +
              "5- Modificar un empleado" + "\n" +
              "6- Listar todos los alumnos" + "\n" +
              "7- Buscar un empleado por su legajo" + "\n" +
              "8- Listar todos los empleados" + "\n" +
              "S- Salir");
        }

        public static void AgregarAlumno(Facultad1 Facu)
        {// OPCION PARA CODIGO AUTOMATICO
            /*int cod = 0;
            List<Alumno> ListAlum = Facu.TraerAlumnos();
            if (ListAlum != null)
            {
                cod = ListAlum.Last<Alumno>().Codigo;
                cod += 1;
            }*/
            Console.Clear();
            Console.WriteLine("Complete los datos del alumno a ingresar"
                + "\n");

            int codigo = ConsolaUtils.PedirInt("Código");
            string nombre = ConsolaUtils.PedirNombre("Nombre");
            string apellido = ConsolaUtils.PedirNombre("Apellido");
            DateTime fechaNac = ConsolaUtils.PedirFecha("Fecha Nacimiento");
            //int codigo = ConsolaUtils.PedirInt("Código"); OPCION
            Alumno Alumno1 = new Alumno(apellido, fechaNac, nombre, codigo);
            Console.WriteLine(Alumno1.ToString());
            Facu.AgregarAlumno(Alumno1);
            Console.ReadKey();
        }
        public static void AgregarEmpleado(Facultad1 Facu)
        {
            
            TipoEmpleado tipoempl = TipoEmpleado.Docente;
            int opcion=PedirTipoEmpleado();
            if (opcion == 0)
            { tipoempl = TipoEmpleado.Bedel; }
            else
            {
                if (opcion == 1)
                { tipoempl = TipoEmpleado.Directivo; }
            }
            Console.WriteLine("Complete los datos del empleado a ingresar"
                + "\n");

            int legajo = ConsolaUtils.PedirInt("Legajo");
            string nombre = ConsolaUtils.PedirNombre("Nombre");
            string apellido = ConsolaUtils.PedirNombre("Apellido");
            DateTime fechaNac = ConsolaUtils.PedirFecha("Fecha Nacimiento");
            DateTime fechaingreso = DateTime.Today;
            //int codigo = ConsolaUtils.PedirInt("Código"); OPCION
            if (tipoempl == TipoEmpleado.Bedel)
            {
                string apodo = ConsolaUtils.PedirNombre("Apodo");
                AgregarBedel(Facu, nombre, fechaNac, apellido,fechaingreso,legajo,apodo);
  
            }
            if (tipoempl == TipoEmpleado.Directivo)
            {
                AgregarDirectivo(Facu,nombre, fechaNac, apellido, fechaingreso, legajo);
            }
            if(tipoempl==TipoEmpleado.Docente)
            {
                AgregarDocente(Facu, nombre, fechaNac, apellido, fechaingreso, legajo);
               
            }
                       
            Console.ReadKey();
        }
      
        public static void AgregarBedel(Facultad1 Facu, string nombre,DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo, string apodo)
        {
            Bedel Empleado1 = new Bedel(apellido, fechaNac, nombre, fechaingreso, legajo, apodo);
            Console.WriteLine(Empleado1.ToString());
            Facu.AgregarEmpleado(Empleado1);
                  
        }
        public static void AgregarDirectivo(Facultad1 Facu,string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo)
        {
           Directivo Empleado1 = new Directivo (apellido, fechaNac, nombre, fechaingreso, legajo);
            Console.WriteLine(Empleado1.ToString());
            Facu.AgregarEmpleado(Empleado1);
            
        }
        public static void AgregarDocente(Facultad1 Facu, string nombre, DateTime fechaNac, string apellido, DateTime fechaingreso, int legajo)
        {
            Docente Empleado1 = new Docente (apellido, fechaNac, nombre, fechaingreso, legajo);
            Console.WriteLine(Empleado1.ToString());
            Facu.AgregarEmpleado(Empleado1);
            
        }
        public static void EliminarAlumno(Facultad1 Facu)
        {
            Console.Clear();
            int codigo = ConsolaUtils.PedirInt("Ingrese el código del alumno:");
            Facu.EliminarAlumno(codigo);
        }
        public static void EliminarEmpleado(Facultad1 Facu)
        {
            Console.Clear();
            int codigo = ConsolaUtils.PedirInt("Ingrese el legajo del empleado:");
            Facu.EliminarEmpleado(codigo);


        }
        public static void ListarAlumno(Facultad1 Facu)
        {
            if (Facu.TraerAlumnos() == null)
            { }
            if (Facu.TraerAlumnos().Any<Alumno>())
            { }

        }
        /* public override bool Equals(Object o)
         {
             if (o == null)
             {
                 return false;
             }

             if (this._codigo == ((Alumno)o).Codigo)
             {
                 return true;
             }

             return false;
         }*/
        public static void ListarTipos()
        {
            Console.WriteLine("TIPOS DE EMPLEADOS" + "\n");
            string[] tipos = Enum.GetNames(typeof(TipoEmpleado));
            Array.Sort(tipos);
            int i = 0;
            foreach (var name in tipos)
            {
                TipoEmpleado tipoempl = (TipoEmpleado)Enum.Parse(typeof(TipoEmpleado), name);
                Console.Write(i+") "+tipoempl+"\n");
                i += 1;

            }
        }
        public static int PedirTipoEmpleado()
        {
            bool validar;
            int opcion;
            do
            {
                validar = true;
                Console.Clear();
                ListarTipos();
                //TipoEmpleado ? tipoempl=null;
                opcion = ConsolaUtils.PedirInt("Ingrese el tipo de empleado que desea cargar" + "\n");

                if (opcion != 0 && opcion != 1 && opcion != 2)
                {
                    ConsolaUtils.MsjErr();
                    Console.ReadKey();
                    validar = false;
                }

            } while (!validar);
            
            return opcion;

        }
    }
}
