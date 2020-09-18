using System;
using System.Collections.Generic;
using System.Text;

namespace Ü_M13_Interfaces
{
    class Transportmittel
    {
        // die Klasse ist kopiert von M11
        enum Zustand { aus, an }
        string Modell { get; }
        public double Preis { get; set; }
        uint maximalGeschwindigkeit;
        public uint AktuelleGeschwindigkeit { get; private set; }
        Zustand FZustand;

        // ctor
        public Transportmittel(string name, double preis, uint maxGeschwindigkeit)
        {
            Modell = name;
            Preis = preis;
            maximalGeschwindigkeit = maxGeschwindigkeit;
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        // methods
        public uint Beschleunige(uint erhöhung)
        {
            uint möglicheErhöhung = maximalGeschwindigkeit - AktuelleGeschwindigkeit;
            if (AktuelleGeschwindigkeit < maximalGeschwindigkeit)
            {
                if (FZustand == Zustand.an)
                {
                    if (erhöhung <= möglicheErhöhung)
                    {
                        AktuelleGeschwindigkeit += erhöhung;
                    }

                }
            }
            else
                AktuelleGeschwindigkeit = maximalGeschwindigkeit;
            Console.WriteLine("Beschleunigen von Transportmittel");
            return AktuelleGeschwindigkeit;
        }

        public void StarteMotor()
        {
            FZustand = Zustand.an;
        }

        public void StoppeMotor()
        {
            FZustand = Zustand.aus;
        }

        public virtual string BeschreibeMich()
        {
            return $@"
{Modell}, ({Preis} €)
Maximale Geschwindigkeit: {maximalGeschwindigkeit} km/h
Zustand: {FZustand}
Aktuelle Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }
    }
}
