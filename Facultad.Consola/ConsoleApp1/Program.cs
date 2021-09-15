using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
                Menu();
                eleccion = Console.ReadLine();
                switch(eleccion)
                {
                    case "1":
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
            } while (opcion == false);
        }

        public static void Menu()
        {
            Console.WriteLine("Bienvenidos!!!" + "\n" +
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
    }
}
