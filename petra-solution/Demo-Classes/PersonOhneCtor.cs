using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Classes
{
    public class PersonOhneCtor
    {
        public string Nachname { get; set; } //Property
        internal string Vorname { get; set; } 
        private int Alter { get; set; }

        //leere Konstruktoren (ohne Parameter) werden automatisch erstellt

        //public PersonOhneCtor()
        //{

        //}

    }

    public class PersonOhneCtor2
    {
        static void Methode()
        {
        PersonOhneCtor person1 = new PersonOhneCtor();
            //person1.Alter //nicht möglich
            person1.Vorname = "x";
        }

        
    }
}
