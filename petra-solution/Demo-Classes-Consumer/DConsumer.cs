using System;
using Demo_Classes;

namespace Demo_Classes_Consumer
{
    class DConsumer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Klassenbibliothek verwenden ===");
            Console.WriteLine("--- Datentypen ---");
            Console.WriteLine("Types.ZeigeCharDefault('d'): {0}", Types.ZeigeCharDefault('d'));
            Console.WriteLine("ZeigeReferenz: {0}", Types.ZeigeReferenz());
            Console.WriteLine("ZeigeReferenzVergleich: {0}", Types.ZeigeReferenzVergleich());
            Console.WriteLine("ZeigeReferenzVergleich: {0}", Types.ZeigeStringVergleich());

            Console.WriteLine("\n\n--- Klassen ---");
            //_type_ _identifier_ = _wert_;
            PersonOhneCtor personOhneCtor = new PersonOhneCtor();
            // obwohl kein Ctor in der Klasse definiert, ist er trotzdem verwendbar
            personOhneCtor.Nachname = "Mustermann";
            Console.WriteLine("personOhneCtor.GetType(): {0}", personOhneCtor.GetType());
            Console.WriteLine("personOhneCtor.GetType(): {0}", personOhneCtor.GetType().Assembly);
            //Console.WriteLine("personOhneCtor.GetType(): {0}", personOhneCtor.GetType().GetMembers());
            //Console.WriteLine("personOhneCtor.GetType(): {0}", Demo_Classes.PersonOhneCtor.GetType); // geht nicht

            // Hier ist nur die Prop 'Nachname' nutzbar
            // Aber darf man auch andere Member der klasse mindestens sehen?
            Console.WriteLine("Members:");
            foreach (var item in personOhneCtor.GetType().GetMembers())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFields"); //leer, hat jede Property ein entsprechendes Files?
            foreach (var item in personOhneCtor.GetType().GetFields())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("keine Fields");

            // ==========================
            #region Konstruktoren
            // Konstruktoren
            Console.WriteLine("\n\n--- Konstruktoren ---");

            //PersonMitCtor personMitCtor = new PersonMitCtor(); //der leere automatische Konstuktor ist nicht mehr verfügbar
            PersonMitCtor personMitCtor = new PersonMitCtor("Mustername");
            Console.WriteLine("personMitCtor.Nachname: {0}", personMitCtor.Nachname);

            // ==========================
            // mehrere Konstruktoren
            PersonMitCtor personMitCtor1 = new PersonMitCtor();
            PersonMitCtor personMitCtor2 = new PersonMitCtor(personMitCtor);
            Console.WriteLine("personMitCtor2.Nachname: {0}", personMitCtor2.Nachname);
            foreach (var item in personMitCtor2.GetType().GetProperties()) //nur public sind sichtbar
            {
                Console.WriteLine("personMitCtor2.GetType().GetProperties(): {0}", item);
            }

            #endregion Konstruktoren
            // ==========================
            #region Fields
            //Klassen mit Feldern ohne Properties
            Console.WriteLine("\n\n --- Klassen mit Feldern ---");
            PersonMitFeldOhneProp personMitFeldOhneProp = new PersonMitFeldOhneProp();
            personMitFeldOhneProp.nachname = "NN";
            Console.WriteLine("personMitFeldOhneProp.nachname: {0}", personMitFeldOhneProp.nachname); // NN
            Console.Write("personMitFeldOhneProp.GetType().GetFields(): ");
            foreach (var item in personMitFeldOhneProp.GetType().GetFields()) // nur public
            {
                Console.WriteLine(item);
            }

            PersonMitFeldOhneProp personMitFeldOhneProp1 = new PersonMitFeldOhneProp("MM");
            Console.WriteLine("personMitFeldOhneProp1.nachname: {0}", personMitFeldOhneProp1.nachname); // MM

            // Austesten SetVorname
            personMitFeldOhneProp1.SetVorname("vn");
            // Console.WriteLine("personMitFeldOhneProp1.vorname: {0}", personMitFeldOhneProp1.vorname); // geht nicht weil private (verändern durch methode (Setter) schon) und kein öffentlicher Getter
            personMitFeldOhneProp1.GetVorname();
            Console.WriteLine("personMitFeldOhneProp1.GetVorname(): {0}", personMitFeldOhneProp1.GetVorname());



            #endregion





            Console.ReadKey();

        }
    }
}
