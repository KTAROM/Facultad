using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria.Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool opcion = true;
            string eleccion;
            do
            {
                Facultad1 Economicas = new Facultad1("FCE");
                Console.WriteLine("Bienvenidos a " + Economicas.Nombre + "\n");
               Menu();
                eleccion = Console.ReadLine();
                switch(eleccion.ToUpper())
                {
                    case "1":
                        AgregarAlumno(Economicas);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
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
            } while (opcion == false);
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
              "8- Listar todos los empleados"+"\n"+
              "S- Salir");
        }
      
    public static void AgregarAlumno(Facultad1 Facu)
        {
            int cod = 0;
            List<Alumno> ListAlum = Facu.TraerAlumnos();
            if (ListAlum != null)
            {
                cod = ListAlum.Last<Alumno>().Codigo;
                cod += 1;
            }
            Console.WriteLine("Complete los datos del alumno a ingresar"
                +"\n"+"Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento");
            DateTime fechaNac = DateTime.Parse(Console.ReadLine());
            Alumno Alumno1 = new Alumno(apellido, fechaNac, nombre, cod);
            Facu.AgregarAlumno(Alumno1);
        }
    }
}
