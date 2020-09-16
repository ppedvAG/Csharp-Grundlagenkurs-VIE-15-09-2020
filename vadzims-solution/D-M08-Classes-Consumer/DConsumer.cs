using D_M08_Classes;
using System;

namespace D_M08_Classes_Consumer
{
    class DConsumer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Klassenbibliothek verwenden === ");

            Console.WriteLine("\n--- Datentypen ---");

            Console.WriteLine("CharDefault: {0}", Types.ZeigeCharDefault('d')); ;

            Console.WriteLine("ZeigeReferenz: {0}", Types.ZeigeReferenz());

            Console.WriteLine("ZeigeReferenzVergleich: {0}", Types.ZeigeReferenzVergleich());

            Console.WriteLine("ZeigeStringVergleich: {0}", Types.ZeigeStringVergleich());

            Console.WriteLine("\n\n--- Klassen ---");

            // _type_ _identifier_ = _wert_;
            PersonOhneCtor personOhneCtor = new PersonOhneCtor();
            // obwohl kein Ctor in der Klasse definiert, ist er trotzdem verwendbar
            personOhneCtor.Nachname = "Mustermann";
            Console.WriteLine("personOhneCtor.GetType(): {0}", personOhneCtor.GetType());

            // Hier ist nur die Prop 'Nachname' nutzbar
            // Aber darf man auch andere Members der Klasse mindestens sehen?
            Console.WriteLine("\nMembers");
            foreach (var item in personOhneCtor.GetType().GetMembers())
            {
                Console.WriteLine(item);
            }
            /*
System.String get_Nachname()
Void set_Nachname(System.String)
System.Type GetType()
System.String ToString()
Boolean Equals(System.Object)
Int32 GetHashCode()
Void .ctor()
System.String Nachname
            */
            // D_M08_Classes.PersonOhneCtor.GetType()

            Console.WriteLine("\nFields");
            foreach (var item in personOhneCtor.GetType().GetFields())
            {
                Console.WriteLine(item);
            }
            // kommt nichts raus
            // hat jede Property ein entsprechendes Field??? #todo

            Console.ReadKey();
        }
    }
}
