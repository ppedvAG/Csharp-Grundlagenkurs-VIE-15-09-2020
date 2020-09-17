using System;
using System.Collections.Generic;
using System.Text;

namespace D_M11_Inheritence
{
    class Subklasse : Superklasse
    {
        //public string EinfacheMethode()
        //{
        //    return "Einfache Methode in Subklasse wurde aufgerufen";
        //}
        // ist das Überschreiben gewünscht, kann man das mit dem Wort 'new' zeigen
        new public string EinfacheMethode()
        {
            return "Einfache Methode in Subklasse wurde aufgerufen";
        }

        //new public virtual string KeineEinfacheMethode()
        //{
        //    return "KeineEinfache Methode in Subklasse wurde aufgerufen";
        //}

        public override string KeineEinfacheMethode()
        {
            return "KeineEinfache override Methode in Subklasse wurde aufgerufen";
        }
    }
}
