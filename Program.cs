using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_VT_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 3];
            Random aleatorio = new Random();

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(11); 
                }
            }

            int suma = 0;
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                    suma += matriz[f, c];
                }

                Console.WriteLine("|\t{0}", suma);
                suma = 0;
            }

            int sumaTotal = 0;
            Console.WriteLine("-------------------------------");
            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    suma += matriz[f, c];
                }

                Console.Write("{0}\t", suma);
                sumaTotal += suma;
                suma = 0;
            }

            Console.WriteLine("|\t{0}", sumaTotal);
        }
    }
}
