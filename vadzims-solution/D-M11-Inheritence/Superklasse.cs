using System;
using System.Collections.Generic;
using System.Text;

namespace D_M11_Inheritence
{
    class Superklasse
    {
        public string EinfacheMethode()
        {
            return "Einfache Methode in Superklasse wurde aufgerufen";
        }
        // virtuelle Methoden können nicht private sein
        //virtual string VirtuelleMethode()
        //{
        //    return "";
        //}
        public virtual string KeineEinfacheMethode()
        {
            return "KeineEinfache Methode in Superklasse wurde aufgerufen";
        }
    }
}
