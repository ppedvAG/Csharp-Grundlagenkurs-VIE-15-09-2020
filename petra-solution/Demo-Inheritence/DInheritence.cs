using System;

namespace Demo_Inheritence
{
    class D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M11 Vererbung");

            // --- Einfache Methode ---
            Superklasse superklasse = new Superklasse();
            Console.WriteLine("superklasse.EinfacheMethode(): {0}", superklasse.EinfacheMethode());

            Subklasse subklasse = new Subklasse();
            Console.WriteLine("subklasse.EinfacheMethode(): {0}", subklasse.EinfacheMethode());

            // Die Methoden von den entsprechenden Instanzen wurden aufgerufen


            // --- Keine Einfache Methode --- (override)
            // bei Instanzen, deren Datentypen den Konstruktoren entsprechen
            Console.WriteLine("superklasse.KeineEinfacheMethode(): {0}", superklasse.KeineEinfacheMethode());
            Console.WriteLine("subklasse.KeineEinfacheMethode(): {0}", subklasse.KeineEinfacheMethode());

            // bei Instanzen, deren Datentypen den Konstruktoren NICHT entsprechen
            // rechts darf ohne Casting Konstruktor von abgeleiteten Klassen stehen
            // Datentyp links heißt Variablentyp
            // Datentyp rechts heißt Laufzeittyp
            Superklasse subklassevonSuper = new Subklasse(); //Polymorphismus
            Console.WriteLine("subklassevonSuper.EinfacheMethode(): {0}", subklassevonSuper.EinfacheMethode());
            Console.WriteLine("subklassevonSuper.KeineEinfacheMethode(): {0}", subklassevonSuper.KeineEinfacheMethode());
            // wurde eine Methode beim Ableiten überdeckt, dann wird die Variante der Methode vom Variablentyp genommen
            // wurde eine Methode beim Ableiten überschrieben (override), dann wird die Variante der Methode vom Laufzeittyp genommen


            Console.ReadKey();

        }
    }
}
