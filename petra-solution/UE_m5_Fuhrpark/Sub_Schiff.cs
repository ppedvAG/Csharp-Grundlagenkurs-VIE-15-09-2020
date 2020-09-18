using System;
using System.Collections.Generic;
using System.Text;

namespace UE_m5_Fuhrpark
{
    class Sub_Schiff : Transport
    {
        int AnzahlPassagiere { get; }


        public Sub_Schiff(string name, uint maxgeschw, double preis, int anzahlPassagiere) : base(name, maxgeschw, preis)
        {
            this.AnzahlPassagiere = anzahlPassagiere;
        }

        public override string BeschreibeMich()
        {
            string Beschreibung = base.BeschreibeMich() + "\nAnzahlPassagiere: " + AnzahlPassagiere;
            return Beschreibung;
        }




    }
}
