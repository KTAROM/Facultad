using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria.Entidades;
using Facultad.ConsolaUtils1;
using Facultad.ExceptionNoHayAlumno;

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
                        ModificarEmpleado(Economicas);
                        break;
                    case "6":
                        ListarAlumnos(Economicas);
                        break;
                    case "7":
                        BuscarPorLegajo(Economicas);
                        break;
                    case "8":
                        ListarEmpleados(Economicas);
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
              "7- Buscar un empleado por su nombre" + "\n" +
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
         try
            {
                Facu.EliminarAlumno(codigo);                           
          }
            catch(ExceptionNoHayAlumnos ex)
            {
                Console.WriteLine("Aún no existen alumnos ingresados");
                Console.ReadKey();
                
            }
           
            /*bool existe = false;
            List<Alumno> ListaAlumnos = Facu.TraerAlumnos();
           
            if (ListaAlumnos.Count() != 0)
            {
                foreach (Alumno alumno in ListaAlumnos)
                {

                    if (alumno.Codigo.Equals(codigo))
                    {
                        existe = true;

                    }

                }
                if (existe)
                {
                    Facu.EliminarAlumno(codigo);
                    Console.WriteLine("El alumno ha sido eliminado");
                }
                else { ConsolaUtils.MsjErr(); }
            }

            else { Console.WriteLine("Aún no se han ingresado alumnos"); }
            Console.ReadKey();*/
        }
        public static void EliminarEmpleado(Facultad1 Facu)
        {
            Console.Clear();
            int codigo = ConsolaUtils.PedirInt("Ingrese el legajo del empleado:");
            Facu.EliminarEmpleado(codigo);


        }
        public static void ListarAlumnos(Facultad1 Facu)
        {
            Console.Clear();
            List<Alumno> ListaAlum = new List<Alumno>();
            try
            {
                ListaAlum=Facu.TraerAlumnos();
                Console.WriteLine("LISTA DE ALUMNOS!!!");
            }
            catch(ExceptionNoHayAlumnos ex)
            {
                Console.WriteLine("Aún no existen alumnos ingresados");
                Console.ReadKey();
            }
            if (ListaAlum.Any())
            {
                foreach (Alumno alum in ListaAlum)
                {
                    Console.WriteLine(alum.GetCredencial());

                }
                Console.ReadKey();
            }
        }
        public static void ListarEmpleados(Facultad1 Facu)
        {
            Console.Clear();
            List<Empleado> ListaEmp = new List<Empleado>();
            try
            {                
                ListaEmp = Facu.TraerEmpleados();
                Console.WriteLine("LISTA DE EMPLEADOS!!!");
            }
            catch (ExceptionNoHayAlumnos ex)
            {
                Console.WriteLine("Aún no existen empleados ingresados");
                Console.ReadKey();
            }
            if (ListaEmp.Any())
            {
                foreach (Empleado empl in ListaEmp)
                {
                    Console.WriteLine(empl.GetCredencial());

                }
                Console.ReadKey();
            }
        }
        public static void ModificarEmpleado(Facultad1 Facu)
        {
            Console.WriteLine(
             "Ingrese el dato que desea modificar:" + "\n" +
             "1- Nombre" + "\n" +
             "2- Apellido" + "\n" +
             "3- Fecha de Nacimiento" + "\n" +
             "4- Legajo" + "\n" +
             "5- Salario" + "\n" +
             "6- Listar todos los alumnos" + "\n" +
             "7- Buscar un empleado por su nombre" + "\n" +
             "8- Listar todos los empleados" + "\n" +
             "S- Salir");

        }
        public static void BuscarPorLegajo(Facultad1 Facu)
        {
            Console.Clear();
            try
            {
                string nombre = ConsolaUtils.PedirNombre("Ingrese el nombre del empleado que desea buscar:");
                List<Empleado> EmplNombre = Facu.TraerEmpleadosPorNombre(nombre);
                if (EmplNombre.Any())
                {
                    foreach (Empleado empl in EmplNombre)
                    {
                        Console.WriteLine(empl.GetCredencial());
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No hay empleados registrados con ese nombre");
                    Console.ReadKey();
                }
            }
            catch(ExceptionNoHayAlumnos ex)
            {
                Console.WriteLine("No hay empleados ingresados");
                Console.ReadKey();
            }
        }
        
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
