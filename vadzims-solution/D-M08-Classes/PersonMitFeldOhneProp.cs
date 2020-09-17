using System;
using System.Collections.Generic;
using System.Text;

namespace D_M08_Classes
{
    public class PersonMitFeldOhneProp
    {
        // ohne Modifizierer sind die Felder private
        public string nachname;
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
