using System;
using System.Collections.Generic;
using System.Text;

namespace Ü_M11_Inheritence
{
    class PKW : Transportmittel
    {
        public int AnzahlTüren { get; set; }
        public int GefahreneKm { get; set; }
        public int MaxLadung { get; set; }
        public PKW(string name, double preis, uint maximalGeschwindigkeit, int anzahlTüren, int gefahreneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            AnzahlTüren = anzahlTüren;
            GefahreneKm = gefahreneKm;
        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nAnzahlTüren: {AnzahlTüren}";
        }
    }
}
