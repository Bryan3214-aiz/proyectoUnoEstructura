using System;


using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\tProgramas realizados por:\n");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - Bryan Leiva Mejia\n - Sebas Mora Rodriguez\n - Kenny Aragon Cascante");
            Console.ReadLine();

            //Subdivision de los ejercicios.
            string opcion = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\tMENU PRINCIPAL\n");//MENU PRINCIPAL, en el cual el usuario puede decidir si ingresar, ver, modificar o eliminar un dato.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A -> Ejercicio 1 - Matriz (suma esquinas)");
                Console.WriteLine("B -> Ejercicio 2 - Matriz (suma diagonales)");
                Console.WriteLine("C -> Ejercicio 3 - Programa para proveedores");
                Console.WriteLine("D -> Salir");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Opcion elegida: ");
                Console.ForegroundColor = ConsoleColor.White;
                opcion = Console.ReadLine().ToUpper();
                switch (opcion)
                {
                    case "A": ClsEjercicio1.ejercicioUno(); break;
                    case "B": ClsEjercicio2.ejercicioDos(); break;
                    case "C": ClsEjercicio3.ejercicioTres(); break;
                    case "D": Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\n\tHasta la proxima, primer proyecto terminado =)"); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t -- ERROR 504 - Error de formato de datos --");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                        break;
                }
                Console.ReadLine();
            } while (!opcion.Equals("D"));
        }  
    }
}

