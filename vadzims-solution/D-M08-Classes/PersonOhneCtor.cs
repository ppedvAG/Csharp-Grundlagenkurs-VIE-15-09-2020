using System;
using System.Collections.Generic;
using System.Text;

namespace D_M08_Classes
{
    public class PersonOhneCtor
    {
        public string Nachname { get; set; }
        internal string Vorname { get; set; }
        private int Alter { get; set; }

        //leere Konstruktoren (ohne Parameter) werden automatisch erstellt
        //public PersonOhneCtor()
        //{

        //}
    }

    class MyClass
    {
        static void Methode()
        {
            PersonOhneCtor person = new PersonOhneCtor();
            // person.Alter //nicht erreichbar
            PersonOhneCtor p = new PersonOhneCtor();
        }
    

private PersonOhneCtor person = new PersonOhneCtor();
PersonOhneCtor p = new PersonOhneCtor();        

        // #todo 
        // warum kann ich auf die Instanzen nicht zugreifen?
        
        
    }
}
