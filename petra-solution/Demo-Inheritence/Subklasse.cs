using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Inheritence
{
    class Subklasse : Superklasse
    {
        new public string EinfacheMethode() //ist überschreiben gewünscht kann man Wort "new" verwenden
        {
            return "Einfache Methode in Subklasse wurde aufgerufen.";
        }

        // virtuelle Methoden können nicht private sein
        public override string KeineEinfacheMethode() //geht auch mit new wenn virtual
        {
            return "Keine Einfache override Methode in Subklasse wurde aufgerufen.";
        }


    }
}
