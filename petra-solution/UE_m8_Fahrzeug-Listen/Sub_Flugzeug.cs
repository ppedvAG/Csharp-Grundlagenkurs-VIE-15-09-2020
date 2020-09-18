using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UE_m5_Fuhrpark
{
    class Sub_Flugzeug : Transport, IKannAndereTransportieren
    {
        uint maxHoehe;
        uint AktHoehe { get; set; }
        public Transport[] AktTransMittelLadung { get; set; }
        public int MaxTransportAnzahl { get; set; }
        public int AktTransportAnzahl { get; set; }

        public Sub_Flugzeug(string name, uint maxgeschw, double preis, uint maxHoehe, int maxLadung) : base(name, maxgeschw, preis)
        {
            this.maxHoehe = maxHoehe;
            this.AktHoehe = 0;
            MaxTransportAnzahl = maxLadung;
        }

        public override string BeschreibeMich()
        {
            string Beschreibung = base.BeschreibeMich() + "\nMax Höhe: " + maxHoehe + "\nAktuelle Höhe:" + AktHoehe + "\nTransportierte Transportmittel:" + AktTransMittelLadung;
            return Beschreibung;
        }


        public int Beladen(Transport[] transportsZuBeladen)
        {
            if (AktTransMittelLadung is null) // Ist notwendig sonst kommt "is empty" Exception
                AktTransMittelLadung = Array.Empty<Transport>();
            
            Transport[] neueLadung = AktTransMittelLadung.Concat(transportsZuBeladen).ToArray();
            if (neueLadung.Length <= MaxTransportAnzahl)
            {
                AktTransMittelLadung = neueLadung;
                AktTransportAnzahl = AktTransMittelLadung.Length;
            }
            else
            {
                Console.WriteLine("Max Anzahl erreicht, Beladen fehlgeschlagen");
            }
            return AktTransportAnzahl;
        }

        public int Entladen(Transport[] transportsZuEntladen)
        {
            // Transport[] neueLadung = Array.Empty<Transport>(); // Länge muss beim Anlegen von Arrays nicht unbedingt angegeben werden
            // Transport[] neueLadung = {}; // Hinweis: Avoid zero length array allocations!
            Transport[] neueLadung = AktTransMittelLadung;

            foreach (var item in transportsZuEntladen)
            {
                neueLadung = neueLadung.Where(el => el != item).ToArray();
            }

            AktTransMittelLadung = neueLadung;

            AktTransportAnzahl = AktTransMittelLadung.Length;
            return AktTransportAnzahl;
        }
    }
}
