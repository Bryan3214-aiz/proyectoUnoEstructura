using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructura
{
    internal class ClsEjercicio3
    {
        public static void ejercicioTres()
        {
            string opcion = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\tBienvenido al registro de proveedores de la empresa\n");//MENU PRINCIPAL, en el cual el usuario puede decidir si ingresar, ver, modificar o eliminar un dato.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A -> Agregar nuevo proveedor\nB -> Consultar proveedor\nC -> Modificar proveedor\nD -> Borrar proveedor\nE -> Salir");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Opcion elegida: ");
                Console.ForegroundColor = ConsoleColor.White;
                opcion = Console.ReadLine().ToUpper();
                switch (opcion)
                {
                    case "A": ClsFuncionesProveedores.Agregar(); break;
                    case "B": ClsFuncionesProveedores.Consultar(); break;
                    case "C": ClsFuncionesProveedores.Modificar(); break;
                    case "D": ClsFuncionesProveedores.Remover(); break;
                    case "E": ClsFuncionesProveedores.ActualizarArticulos(); break;
                    case "F": Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\n\tHasta la proxima, esperamos tu experiencia haya sido agradable =)"); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t -- ERROR 504 - Error de formato de datos --");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                        break;
                }
                Console.ReadLine();
            } while (!opcion.Equals("E"));
        }
    }
}
