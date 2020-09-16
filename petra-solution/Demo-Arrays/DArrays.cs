using System;

namespace Demo_Arrays
{
    class DArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M06 Arrays");

            // ===========================================
            #region Datentypen
            Console.WriteLine("Darf man verschiedene Datentypen in einem Array verwenden?");
            Console.WriteLine("Nein, weil man gleich beim Definieren von Arrays einen Datentyp angeben muss.");
            // var[] vars = new var[] { 4, "d"}; // geht nicht

            string[] strings = new string[] { "s1", "s2" };

            #endregion
            // ===========================================
            #region Mehrdimensionale Arrays

            int[,] matrix = new int[3, 4];
            //string[,] matrix = new string[3, 4];

            Console.WriteLine("matrix.Length: {0}", matrix.Length); // 12
            Console.WriteLine("matrix.Rank: {0}", matrix.Rank); // 2

            string numbers = "312420518212";

            //Array befüllen
            //for (int i = 0, s = 0, r = 0; i < matrix.Length; i++)
            //{
            //    matrix[s, r] = numbers[i];
                
            //    if (s == 3)
            //        s = 0;
            //    else
            //        s++;

            //    if (r == 4)
            //        r = 0;
            //    else
            //        r++;

            //}


            for (int i = 0, s = 0; i < numbers.Length; s++, i++)
            {
                
                for (int r = 0; r < 3; r++)
                {
                    matrix[s, r] = (int)Char.GetNumericValue(numbers[i]);
                    Console.WriteLine("i: {0}, s: {1}, r: {2}", numbers[i], s,r);
                    i++;
                }

                //Console.WriteLine("i: {0}, s: {1}, r: {2}", numbers[i], s, r);

                //matrix[s, r] = (int)Char.GetNumericValue(numbers[i]);

                

            }

            //matrix[0, 0] = numbers[0];
            //matrix[1, 2] = 1;


            Console.WriteLine("\nMatrix:");
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }







            #endregion










            Console.ReadKey();


        }
    }
}
