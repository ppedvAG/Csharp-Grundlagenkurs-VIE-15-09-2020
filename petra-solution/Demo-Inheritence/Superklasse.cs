using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Inheritence
{
    class Superklasse
    {
        public string EinfacheMethode ()
        {
            return "Einfache Methode in Superklasse wurde aufgerufen.";
        }

        // virtuelle Methoden können nicht private sein
        public virtual string KeineEinfacheMethode()
        {
            return "Keine Einfache Methode in Superklasse wurde aufgerufen.";
        }



    }
}
