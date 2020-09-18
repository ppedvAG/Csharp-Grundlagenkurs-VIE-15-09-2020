using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UE_m5_Fuhrpark
{


    public class Transport
    {
        enum Zustand {an,aus}

        // --- Properties ---
        string Modell { get; } // Muss nicht public sein weil in Methode BeschreibMich aufgerufen, kann auch als Feld angegeben werden
        //Modell: ohne Methode müsste es public und Prop sein, dann kann direkt angesprochen werden
        uint maxGeschwindigkeit; // nur im Konstruktor also wird kein Setter benötigt, muss nicht public sein weil "BeschreibeMich" Wert ausgibt. Passt auch als Feld
        public double Preis { get; set; } // keine Methode wo Preis geändert wird, einfacher wenn Preis als Property angelegt ist
        public uint AktGeschwindigkeit { get; private set; } //uint weil nicht negativ sein kann
        Zustand TranspZustand; //Muss nicht als Prop angelegt werden, weil gesetzt und gelesen wird es in den Methoden der Klassen


        //Konstruktor
        public Transport(string name, uint maxgeschw, double preis)
        {
            Modell = name;
            maxGeschwindigkeit = maxgeschw;
            Preis = preis;
            AktGeschwindigkeit = 0;
            TranspZustand = Zustand.aus;
        }


        //Methoden

        public void Beschleunige()
        {
            if (AktGeschwindigkeit < maxGeschwindigkeit)
            {
                AktGeschwindigkeit++;
            }
        }

        public void Bremse()
        {
            if (AktGeschwindigkeit > 0)
            {
                AktGeschwindigkeit--;
            }
        }

        public void StarteMotor()
        {
            if (TranspZustand == Zustand.aus)
            {
                TranspZustand = Zustand.an;
            }
        }

        public void StoppeMotor()
        {
            if (TranspZustand == Zustand.an)
            {
                TranspZustand = Zustand.aus;
            }
        }

        public virtual string BeschreibeMich()
        {
            string Beschreibung = "Modell:" + Modell + "\nMax. Geschwindigkeit:" + maxGeschwindigkeit + "\nTransport Zustand:" + TranspZustand;
            return Beschreibung;

        }



    }
}
