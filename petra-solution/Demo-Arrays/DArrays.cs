using System;

namespace Demo_Arrays
{
    class DArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M06 Arrays");

            // ===========================================

            // Wie legt man ein Array an?
            string[] stringArr = { "s", "t" };
            string[] stringArr2 = new string[] { "s", "t" };
            string[] stringArr3 = new string[2];


            // ===========================================
            #region Datentypen
            Console.WriteLine("Darf man verschiedene Datentypen in einem Array verwenden?");
            Console.WriteLine("Nein, weil man gleich beim Definieren von Arrays einen Datentyp angeben muss.");
            // var[] vars = new var[] { 4, "d"}; // geht nicht

            string[] strings = new string[] { "s1", "s2" };

            // ===========================================
            // Methoden die den Array-Instanzen angewendet werden können:
            // sprich: nicht statische Methoden aus der Klasse Array

            int[] zahlen = new int[] { 3, 4, 5 };
            //zahlen.Clone();
            //zahlen.CopyTo();
            //zahlen.GetEnumerator();

            // ===========================================
            // Methoden die durch die Klasse Array selbst aufgerufen werden können:
            // sprich: statische Methoden aus der Klasse Array
            int[] restArr = new int [2];
            Array.Copy(zahlen, restArr, 2);
            // für die weiteren Methoden: Definition der Klasse Array



            #endregion
            // ===========================================
            #region Mehrdimensionale Arrays

            int[,] matrix = new int[3, 4];
            //string[,] matrix = new string[3, 4];

            Console.WriteLine("matrix.Length: {0}", matrix.Length); // 12
            Console.WriteLine("matrix.Rank: {0}", matrix.Rank); // 2

            string numbers = "312420518212";
            Console.WriteLine(numbers);

            for (int i = 0, s = 0, r = 0; i < numbers.Length; s++, i++)
            {
                
                for (r = 0; r < 3; r++, i++)
                {
                    matrix[s, r] = (int)Char.GetNumericValue(numbers[i]);
                    
                }
                matrix[s, r] = (int)Char.GetNumericValue(numbers[i]);

            }


            Console.WriteLine("\nMatrix:");
            foreach (var item in matrix)
            {
                Console.Write(item);
            }







            #endregion










            Console.ReadKey();


        }
    }
}
