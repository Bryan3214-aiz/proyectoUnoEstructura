using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructura
{
    internal class ClsEjercicio2
    {
        public static void ejercicioDos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\tEjercicio 2\n\nDescripción:");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Matriz bidimensional con un tamaño de 5x5 para sumar sus diagonales.");
            int[,] matriz = new int[5, 5];
            Random rnd = new Random();
            int diagonalUno = 0;
            int diagonalDos = 0;
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(" -----------------------------------------------\n");
            for (int fila = 0; fila < 5; fila++) //filas
            {
                for (int columna = 0; columna < 5; columna++) // columnas
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    matriz[fila, columna] = rnd.Next(100);
                    Console.Write($"\t{matriz[fila, columna]}");
                    if (fila == columna)
                    {
                        diagonalUno += matriz[fila, columna]; 
                    }
                    if(fila == 4 - columna)
                    {
                        diagonalDos += matriz[fila, columna];
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n -----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"\t  Suma de las diagonales = {diagonalUno + diagonalDos}");
            Console.ReadLine();
        }
    }
}
