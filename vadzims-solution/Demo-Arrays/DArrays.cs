using System;

namespace Demo_Arrays
{
    class DArrays
    {

        static void Main(string[] args)
        {
            Console.WriteLine("M06 Arrays");

            // ===============================================
            // ein Array anlegen
            string[] stringArr1 = { "d", "t" };
            string[] stringArr2 = new string[] { "d", "t" };
            string[] stringArr3 = new string[2];
            // Oft sieht man im Namen von Arrays Pluralform von den Elementen, die im Array gespeichert sind
            // z.B. numbers, todos, elements usw.


            // ===============================================
            Console.WriteLine("Darf man verschiedene Datentypen in einem Array vereinen?");
            Console.WriteLine("Nein, weil gleich beim Definieren von Arrays man einen Datentyp angeben soll");
            // var[] vars = new var[] { 4, "d"}; // geht nicht

            string[] strings = new string[] { "s1", "s2" };


            // ===============================================
            Console.WriteLine("\n\nDarf man Arrays auch für komplexe Datentypen verwenden?");
            Console.WriteLine("Ja:");            
            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = DateTime.UtcNow;
            DateTime[] tArr = new DateTime[] { dateTime1, dateTime2 };
            foreach (var item in tArr)
            {
                Console.WriteLine(item);
            }


            // ===============================================
            // Methoden, die bei den Array-Instanzen angewendet werden können:
            // sprich: nicht statische Methoden der Klasse Array

            int[] zahlen = new int[] { 3, 4, 5 };
            //zahlen.Clone();
            //zahlen.CopyTo();            
            //zahlen.GetEnumerator();            
            //zahlen.GetLength();
            //zahlen.GetLowerBound();
            //zahlen.GetUpperBound();
            //zahlen.Initialize();
            // zahlen.LongLength(); // non-invokable


            // ===============================================
            // Methoden, die durch die Klasse Array selbst aufgerufen werden können
            // sprich: statische Methoden der Klasse Array
            int[] restArr = new int[2];
            Array.Copy(zahlen, restArr, 2);
            // für die weiteren Methoden schau in der Definition der Klasse Array


            // ===============================================
            // Zwei Arrays zusammenführen mit Concat() von LINQ
            //public Transportmittel[] Belade(Transportmittel[] transport)
            //{
            //    Transportmittel[] neueLadung = AktTransMittelLadung.Concat(transport).ToArray();
            //    AktTransMittelLadung = neueLadung;
            //    return AktTransMittelLadung;
            //}


            // ===============================================
            // leere Arrays
            // #todo
            // CA1825: avoid zero-length array allocations! Use Empty instead
            // die Länge muss beim Anlegen von Arrays nicht unbedingt angegeben werden
            // Transportmittel[] neueLadung = Array.Empty<Transportmittel>();
            // Empty ist nicht gleich null!


            // ===============================================
            // Element aus dem Array löschen
            //public int Entlade(Transportmittel[] transportsZuEntladen)
            //{              
            //    Transportmittel[] neueLadung = AktTransMittelLadung;
            //    foreach (var item in transportsZuEntladen)
            //    {
            //        neueLadung = neueLadung.Where(el => el != item).ToArray();
            //    }
            //    AktTransMittelLadung = neueLadung;
            //    AktLadungAnzahl = AktTransMittelLadung.Length;
            //    return AktLadungAnzahl;
            //}

            // oder
            //            Non - LINQ: (.NET Framework 2.0)

            //            static bool isNotFour(int n)
            //            {
            //                return n != 4;
            //            }

            //            int[] numbers = { 1, 3, 4, 9, 2 };
            //            numbers = Array.FindAll(numbers, isNotFour).ToArray();


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
