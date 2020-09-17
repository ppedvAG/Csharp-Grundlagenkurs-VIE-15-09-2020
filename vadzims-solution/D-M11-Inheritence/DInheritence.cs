using System;

namespace D_M11_Inheritence
{
    class DInheritence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M11 Vererbung");

            Superklasse superklasse = new Superklasse();
            Console.WriteLine("superklasse.EinfacheMethode(): {0}", superklasse.EinfacheMethode());
            Subklasse subklasse = new Subklasse();
            Console.WriteLine("subklasse.EinfacheMethode(): {0}", subklasse.EinfacheMethode());

            // Die Methoden von den entsprechenden Instanzen wurden aufgerufen


            // =============================
            // virtual
            // new virtual
            // override 
            // bei Instanzen, deren Datentypen den Konstruktoren entsprechen

            Console.WriteLine("superklasse.KeineEinfacheMethode(): {0}", superklasse.KeineEinfacheMethode());
            Console.WriteLine("subklasse.KeineEinfacheMethode(): {0}", subklasse.KeineEinfacheMethode());


            // =========================================================
            // virtual
            // override 
            // bei Instanzen, deren Datentypen den Konstruktoren NICHT entsprechen
            // rechts darf ohne Casting Konstruktor von abgeleiteten Klassen stehen
            // Datentyp links heißt Variablentyp
            // Datentyp rechts heißt Laufzeittyp
            Superklasse subklasseVonSuperklasse = new Subklasse();
            Console.WriteLine("subklasseVonSuperklasse.EinfacheMethode(): {0}", subklasseVonSuperklasse.EinfacheMethode());
            Console.WriteLine("subklasseVonSuperklasse.KeineEinfacheMethode(): {0}", subklasseVonSuperklasse.KeineEinfacheMethode());
            // wurde eine Methode beim Ableiten überdeckt, 
            // dann wird die Variante der Methode vom Variablentyp genommen
            // wurde eine Methode beim Ableiten überschrieben (override), 
            // dann wird die Variante der Methode vom Laufzeittyp genommen
            
            
            Console.ReadKey();
        }
    }
}
