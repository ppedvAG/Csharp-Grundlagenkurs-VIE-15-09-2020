using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Classes
{
    public class PersonMitCtor
    {
        public string Nachname { get; set; } //Property
        internal string Vorname { get; set; }
        private int Alter { get; set; }

        // Frage: Überschreiben wir den automatischen leeren Konstruktor?
        // Antwort: der leere automatische Konstuktor ist nicht mehr verfügbar (siehe DConsumers.cs)
        public PersonMitCtor(string nname)
        {
            // this.Nachname = nname; // this kann man in neuerer Version auch weglassen
            Nachname = nname;
        }

        //Sind mehrere Konstruktoren möglich?
        // Antwort: ja, nach dem Prinzip von Overloads bei normalen Methoden

        public PersonMitCtor()
        {

        }

        public PersonMitCtor(PersonMitCtor p)
        {
            Nachname = p.Nachname;
            Vorname = p.Vorname;
            Alter = p.Alter;
        }

        // wird ausgeführt, wenn eine Instanz gelöscht wird
        ~PersonMitCtor()
        {
            Console.WriteLine("Die Person war zu alt.");
        }

    }
}
