using System;
using System.Collections.Generic;
using System.Text;

namespace UE_m5_Fuhrpark
{
    class Sub_PKW : Transport
    {
        bool ElektroJN { get; }

        public Sub_PKW(string name, uint maxgeschw, double preis, bool elektroJN) : base(name, maxgeschw, preis)
        {
            this.ElektroJN = elektroJN;
        }

        public override string BeschreibeMich()
        {
            string Beschreibung = base.BeschreibeMich() + "\nElektroJN: " + ElektroJN;
            return Beschreibung;
        }

    }
}
