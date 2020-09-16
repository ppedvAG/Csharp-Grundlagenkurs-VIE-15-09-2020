using System;

namespace Demo_Arrays
{
    class DArrays
    {

        static void Main(string[] args)
        {
            Console.WriteLine("M06 Arrays");

            // ===============================================
            Console.WriteLine("Darf man verschiedene Datentypen in einem Array vereinen?");
            Console.WriteLine("Nein, weil gleich beim Definieren von Arrays man einen Datentyp angeben soll");
            // var[] vars = new var[] { 4, "d"}; // geht nicht

            string[] strings = new string[] { "s1", "s2" };

            // ===============================================
            // Mehrdimesionale Arrays

            int zeilen = 3, spalten = 4;
            int[,] matrix = new int[zeilen, spalten];
            Console.WriteLine("matrix.Length: {0}", matrix.Length); // 12
            Console.WriteLine("matrix.Rank: {0}", matrix.Rank); // 2, gets the rank (number of dimensions)
            matrix[1, 1] = 3;
            matrix[1, 2] = 1;

            for (int i = 0; i < zeilen; i++)
            {
                for (int j = 0; j < spalten; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            string numbers = "312420518212";

            // Array befüllen
            for (int i = 0, s = 0, r = 0; i < matrix.Length; i++, s++)
            {
                for (r = 0; r < 3; r++)
                {
                    //Console.WriteLine("s: {0}", s);
                    //if (r <= 3)
                    //{
                    //    r++;
                    //    Console.WriteLine("r: {0}", r);
                    //}
                    //else
                    //    r = 0;

                    matrix[s, r] = (int)Char.GetNumericValue(numbers[i]);
                    i++;
                }
                matrix[s, r] = (int)Char.GetNumericValue(numbers[i]);
            }

            Console.WriteLine("\nMatrix:");
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
