using System;
using System.Collections.Generic;
using System.Text;

namespace D_M08_Classes
{
    public class PersonMitCtor
    {
        public string Nachname { get; set; }
        // internal Props sind mit Herz in Intellisence 
        // und in der Memberliste in Solution Explorer markiert
        internal string Vorname { get; set; }
        private int Alter { get; set; }

        // Frage: Überschreiben wir den automatischen leeren Konstruktor?
        // Antwort: ja, der leere automatische Konstruktor ist nicht mehr verfügbar, s. Consumer
        public PersonMitCtor(string nname)
        {
            // this.Nachname = nname; // früher
            Nachname = nname; // jetzt
        }

        // Frage: Sind mehrere Konstruktoren möglich?
        // Antwort: ja. Nach dem Prinzip von Overloads bei normalen Methoden
        public PersonMitCtor()
        {

        }
        public PersonMitCtor(PersonMitCtor p)
        {
            Nachname = p.Nachname;
            Vorname = p.Vorname;
            Alter = p.Alter;
        }

        // Man spart die Tipparbeit, 
        // wenn man erst die Props anlegt und dann das Snippet ctor ausführt
        // oder auf den Schraubenzieher bei der Klasse klickt und durch Quick Actions den Konstruktor anlegt

        // wird ausgeführt, wenn eine Instanz gelöscht wird
        ~PersonMitCtor()
        {
            Console.WriteLine("Die Person war zu alt.");     
        }
    }
}
