using System;
using System.Collections.Generic;
using System.Text;

namespace UE_m5_Fuhrpark
{
    interface IKannAndereTransportieren
    {
        Transport[] AktTransMittelLadung { get; set; }
        int MaxTransportAnzahl { get; set; }
        public int AktTransportAnzahl { get; set; }


        int Beladen(Transport[] transportsZuBeladen);

        /// <summary>
        ///  Methode, die die gewünschten Transportmittel aus dem Ladungs-Array rausnimmt.
        /// </summary>
        /// <param name="transportsZuEntladen">Objekte, die aus dem Ladungsarray gelöscht werden sollen</param>
        /// <returns>Anzahl von Elementen im neuen Array.</returns>
        int Entladen(Transport[] transportsZuEntladen);




    }
}
