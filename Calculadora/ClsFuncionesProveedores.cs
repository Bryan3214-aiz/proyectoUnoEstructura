using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructura
{
    internal class ClsFuncionesProveedores
    {
        private static String[] proveedores = new string[5];
        private static String[] ciudad = new string[5];
        private static int[] articulos = new int[5];
        static int capacidad = 5;
        static int contador = 0;
        public static void Agregar()
        {
            Console.Clear();
            String op = "";
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\n\tREGISTRAR DATOS NUEVO PROVEEDOR");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Nombre del proveedor: ");
                    proveedores[contador] = Console.ReadLine();
                    Console.Write("Ciudad en la que reside: ");
                    ciudad[contador] = Console.ReadLine();
                    Console.Write("Cantidad de articulos: ");
                    articulos[contador] = int.Parse(Console.ReadLine());
                    ++contador;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("¿Desea continuar? (si/no)\n --> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    op = Console.ReadLine().ToLower();
                } while (op == "si" && contador < capacidad);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("\n\tCapacidad limite alcanzada.");
            }
        }
        public static void Modificar()
        {
            Console.Write("Ingrese proveedor: ");
            string consultaProveedor = Console.ReadLine().ToUpper();
            for (int i = 0; i < proveedores.Length; i++)
            {
                if (consultaProveedor == proveedores[i].ToUpper())
                {
                    Console.Write("Actualizar la ciudad: ");
                    ciudad[i] = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\tNo se encontro al proveedor");
                    break;
                }
            }
        }
        public static void Consultar()
        {
            Console.Write("Ingrese proveedor: ");
            string consultaProveedor = Console.ReadLine().ToUpper();
            for (int i = 0; i < proveedores.Length; i++)
            {
                if (consultaProveedor == proveedores[i].ToUpper())
                {
                    Console.WriteLine("El proveedor " + proveedores[i] + " se ubica en la cuidad " + ciudad[i] + " y ofrece " + articulos[i] + " articulos.");
                    break;
                }
                else
                {
                    Console.WriteLine("\n\tNo existe");
                    break;
                }
            }
        }
        public static void Remover()
        {
            Console.Write("Ingrese proveedor: ");
            string consultaProveedor = Console.ReadLine().ToUpper();

            for (int i = 0; i < 5; i++)
            {
                if (consultaProveedor == proveedores[i].ToUpper())
                {
                    proveedores[i] = "";
                    ciudad[i] = "";
                    articulos[i] = 0;
                    Console.WriteLine("\n\tProveedor se elimino con exito.");
                    break;
                }
                else
                {
                    Console.WriteLine("\n\tNo existe el proveedor ingresado.");
                    break;
                }
            }
        }
        public static void ActualizarArticulos() 
        {
            int montoArticulo;
            Console.WriteLine("Ingrese la acción que desea hacer:\r\n 1. Sumar artículos a proveedor \r\n 2. Restar artículos a proveedor");
            byte menu = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese proveedor al que desea buscar: ");
            string consultaProveedor = Console.ReadLine().ToUpper();
            for (int i = 0; i < 5; i++)
            {
                if (consultaProveedor == proveedores[i].ToUpper())
                {
                    if (menu == 2)
                    {
                        Console.WriteLine("Ingrese la cantidad que desea restar");
                        montoArticulo = int.Parse(Console.ReadLine());
                        articulos[i] = articulos[i] - montoArticulo;
                        Console.WriteLine("Cantidad de artículos actualizado a " + articulos[i]);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la cantidad que desea sumar");
                        montoArticulo = int.Parse(Console.ReadLine());
                        ciudad[i] = ciudad[i] + montoArticulo;

                        Console.WriteLine("Cantidad de artículos actualizado a " + articulos[i]);
                    }
                }
            }
        }
    }
}
