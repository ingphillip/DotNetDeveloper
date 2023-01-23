using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    internal class arrays
    {
        // See https://aka.ms/new-console-template for more information
        public void PruebasArrays()
        {
            int[] enteros = new int[5];

            enteros[0] = 2;
            enteros[1] = 4;
            enteros[2] = 6;
            enteros[3] = 8;
            enteros[4] = 9;

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine(enteros[i]);
            }

            string[] nombres = { "Pedro", "Juan", "Fabian" };

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            string[,] paises = new string[2, 3]
            {
    { "Colombia", "España", "Perú" },
    { "Uruguay", "Chile", "Brasil" }
            };

            for (int i = 0; i < paises.GetLength(0); i++)
            {
                for (int j = 0; j < paises.GetLength(1); j++)
                {
                    Console.WriteLine(paises[i, j]);
                }
            }

            string[][] nombresPropios = new string[2][];
            nombresPropios[0] = new string[3] { "Carlos", "Alberto", "Jaime" };
            nombresPropios[1] = new string[3] { "Fabian", "Pedro", "Antonio" };

            for (int i = 0; i < nombresPropios.Length; i++)
            {
                for (int j = 0; j < nombresPropios[i].Length; j++)
                {
                    Console.WriteLine(nombresPropios[i][j]);
                }
            }


            Console.ReadLine();
        }
    }
}
