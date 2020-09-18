using System;
using System.Collections.Generic;

namespace D_M14_GenericStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M14 Generics");

            List<int> intList = new List<int>();

            // =================================
            // Sind die leeren Listen null, wie Arrays?
            // nein
            if (intList is null)
                Console.WriteLine("intList is gleich null");

            // was ist default-Wert?
            Console.WriteLine(intList.ToString()); // System.Collections.Generic.List`1[System.Int32]
            // Console.WriteLine(intList[0]); // System.ArgumentOutOfRangeException: 'Index was out of range. Must be non-negative and less than the size of the collection. '
                                           // if (intList == 0) // keine 0
                                           // #todo

            // =================================
            // hinzufügen in eine Liste
            intList.Add(2);
            intList.Add(4);
            intList.Add(6);
            intList.Add(1);

            // =================================
            // 
            Console.WriteLine("\n\nListen iterieren"); 
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            // =================================
            // 
            Console.WriteLine("\n\nauf einzelne Elemente zugreifen");
            Console.WriteLine("intList[2]: {0}", intList[2]);


            // =================================
            Console.WriteLine("\n\nLöschen ein Element");
            Console.WriteLine("intList.Remove(6): {0}", intList.Remove(6));

            // =================================
            Console.WriteLine("\n\nLöschen ein Element mit Index");
            intList.RemoveAt(1); // ist eine void-Methode
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            // =================================
            Console.WriteLine("\n\nSort()");
            intList.Add(3);
            intList.Add(6);
            intList.Add(9);
            Console.WriteLine("vorm Sort()");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            intList.Sort();
            Console.WriteLine("nach dem Sort()");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }


            // =================================
            Console.WriteLine("\n\nLänge einer Liste");
            Console.WriteLine("intList.Count: {0}", intList.Count);


            // =================================
            Console.WriteLine("\n\nFRAGE: Sind Listen readonly?");

            Console.WriteLine("vor der Zuweisung intList[2] = 5");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            intList[2] = 5;
            Console.WriteLine("nach der Zuweisung intList[2] = 5");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }            

            intList = new List<int>();
            intList.Add(2);
            Console.WriteLine(intList.Count);

            Console.WriteLine("ANTWORT: NEIN, elemente dürfen neue Werte zugewiesen bekommen" +
                "auch die Listenvariable selbst akzeptiert neuen Wert");
            // 



            Console.ReadKey();
        }
    }
}
