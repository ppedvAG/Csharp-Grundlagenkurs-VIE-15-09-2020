using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Classes
{
    public class PersonMitFeldOhneProp
    {
        //Ohne modifier sind die Felder private
        public string nachname; //Field: kein Zugriffswert (void?), camelCase, keine get und set
        private string vorname;
        internal int alter;

        public PersonMitFeldOhneProp()
        {

        }

        public PersonMitFeldOhneProp(string nn)
        {
            nachname = nn;
        }

        public void SetVorname(string vn)
        {
            vorname = vn;
        }

        public string GetVorname()
        {
            return vorname;
        }

    }
}
