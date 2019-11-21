using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Board
    {
        public int[,] matriz;

        public Board()
        {
            matriz = new int[10, 10];
        }

        public void Imprimir()
        {
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void Ingresar()
        {
            
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }
    }
}
