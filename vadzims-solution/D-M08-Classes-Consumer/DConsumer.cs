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
            // Antwort: nur die public-Members, auch die vererbten
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
            Console.WriteLine("keine Fields");
            // kommt nichts raus
            // hat jede Property ein entsprechendes Field??? #todo


            // ======================================
            // Konstruktoren
            // PersonMitCtor personMitCtor = new PersonMitCtor(); // der leere automatische Konstruktor ist nicht mehr verfügbar
            PersonMitCtor personMitCtor = new PersonMitCtor("Musternname"); // der leere automatische Konstruktor ist nicht mehr verfügbar
            Console.WriteLine("personMitCtor.Nachname: {0}", personMitCtor.Nachname);

            // ======================================
            // mehrere Konstruktoren
            Console.WriteLine("\n\nKonstruktoren");
            PersonMitCtor personMitCtor1 = new PersonMitCtor();
            PersonMitCtor personMitCtor2 = new PersonMitCtor(personMitCtor);
            Console.WriteLine("personMitCtor2.Nachname: {0}", personMitCtor2.Nachname);
            foreach (var item in personMitCtor2.GetType().GetProperties()) // nur public sind sichtbar
            {
                Console.WriteLine("personMitCtor2.Prop: {0}", item);
            }


            // ======================================
            // Klasse mit Feldern ohne Properties
            Console.WriteLine("\n\nKlassen mit Feldern");
            PersonMitFeldOhneProp personMitFeldOhneProp = new PersonMitFeldOhneProp();
            personMitFeldOhneProp.nachname = "NN";
            Console.WriteLine("personMitFeldOhneProp.nachname: {0}", personMitFeldOhneProp.nachname); // NN
            Console.WriteLine("\nFields");
            foreach (var item in personMitFeldOhneProp.GetType().GetFields()) // nur public
            {
                Console.WriteLine(item);
            }

            PersonMitFeldOhneProp personMitFeldOhneProp1 = new PersonMitFeldOhneProp("nn");
            Console.WriteLine("personMitFeldOhneProp1.nachname: {0}", personMitFeldOhneProp1.nachname); // nn

            // Austesten SetVorname
            personMitFeldOhneProp1.SetVorname("vn");
            // Console.WriteLine("personMitFeldOhneProp1.vorname: {0}", personMitFeldOhneProp1.vorname); 
            // geht nicht, weil private und kein öffentlicher Getter
            Console.WriteLine("personMitFeldOhneProp1.GetVorname(): {0}", personMitFeldOhneProp1.GetVorname()); 

            


            Console.ReadKey();
        }
    }
}
