using System;
using System.Collections.Generic;

namespace Demo_GenericStructures
{
    class DGenerics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M14 - Generic Structures\n");

            List<int> intList = new List<int>();

            // ==================================
            // Sind die leeren Listen null, wie Arrays ? --> Nein
            if (intList is null)
                Console.WriteLine("intList ist gleich null");

            // Was ist default-Wert?
            // Console.WriteLine(intList[0]); //Argument out of range exception
            //Console.WriteLine(firstOrdefault());


            // ==================================
            // Hinzufügen einer Liste
            intList.Add(2);
            intList.Add(3);
            intList.Add(6);
            intList.Add(8);

            // ==================================
            // Iterieren 
            Console.WriteLine("\n--- Iterieren ---");
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            // ==================================
            // Auf einzelne Elemente zugreifen
            Console.WriteLine("\n--- Auf einzelne Elemente zugreifen ---");
            Console.WriteLine("intList[2]: {0}", intList[2]);

            // ==================================
            Console.WriteLine("\n--- Löschen eines Elements ---");
            Console.WriteLine("intList.Remove(6): {0}", intList.Remove(6));
            
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();



            // ==================================
            Console.WriteLine("\n--- Löschen eines Elements mit Index ---");
            Console.WriteLine("intList.RemoveAt(1):"); // gibt nichts zurück
            intList.RemoveAt(1);
            
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();


            // ==================================
            Console.WriteLine("\n--- Sortieren ---");
            intList.Add(9);
            intList.Add(15);
            intList.Add(2);
            
            Console.WriteLine("Vor dem Sortieren:");
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            intList.Sort();

            Console.WriteLine("Nach dem Sortieren:");
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            // ==================================
            Console.WriteLine("\n--- Länge ---");
            Console.WriteLine("intList.Count: {0}", intList.Count);

            // ==================================
            Console.WriteLine("\nSind Listen readonly?"); // Nein
            intList[1] = 5;

            Console.WriteLine("Nach der Zuweisung:");
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("\nAlso nicht readonly");

            Console.WriteLine("\nNeue Liste zugeordnet:");
            intList = new List<int>();
            intList.Add(2);
            Console.WriteLine("Count: {0}", intList.Count);









            Console.ReadKey();
        }
    }
}
