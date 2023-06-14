using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructura
{
    internal class ClsEjercicio1
    {
        public static void ejercicioUno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\tEjercicio 1\n\nDescripción:");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Matriz bidimensional con un tamaño de 5x5 para sumar sus esquinas.");
            int[,] matriz = new int[5, 5];
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(" -----------------------------------------------\n");
            for (int fila = 0; fila < 5; fila++) //filas
            {
                
                for (int columna = 0; columna < 5; columna++) // columnas
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    matriz[fila, columna] = rnd.Next(100);
                    Console.Write($"\t{matriz[fila, columna]}");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n -----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"\t  Suma de las esquinas = {matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4]}");
            Console.ReadLine();
        }
    }
}
