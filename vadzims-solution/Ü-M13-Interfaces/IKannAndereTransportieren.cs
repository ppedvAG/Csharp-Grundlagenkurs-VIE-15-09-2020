using System;
using System.Collections.Generic;
using System.Text;

namespace Ü_M13_Interfaces
{
    interface IKannAndereTransportieren
    {
        Transportmittel[] AktTransMittelLadung { get; set; }
        public int AktLadungAnzahl { get; set; }
        int MaxTransMittelLadung { get; set; }
        int Belade(Transportmittel[] transport);

        /// <summary>
        /// Methode, die die gewünschten Transportmittel aus dem Ladung-Array rausnimmt.
        /// </summary>
        /// <param name="transportsZuEntladen">Objekte, die aus dem Ladungsarray gelöscht werden sollen</param>
        /// <returns>Anzahl von Elementen im neuen Array
        /// </returns>
        int Entlade(Transportmittel[] transportsZuEntladen);
    }
}
