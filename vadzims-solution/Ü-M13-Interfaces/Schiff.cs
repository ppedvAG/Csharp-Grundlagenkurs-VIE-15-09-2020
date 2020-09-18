using System;
using System.Collections.Generic;
using System.Text;

namespace Ü_M13_Interfaces
{
    class Schiff : Transportmittel
    {
        // Klasse, kopiert aus M11 und weiter modifiziert
        public enum SchiffsTreibstoff
        {
            Diesel,
            Dampf,
            Wind,
            Muskelkraft
        }
        public SchiffsTreibstoff Treibstoff { get; set; }

        public int MaxLadung { get; set; }

        public Schiff(string name, double preis, uint maximalGeschwindigkeit, SchiffsTreibstoff treibstoff) : base(name, preis, maximalGeschwindigkeit)
        {
            Treibstoff = treibstoff;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $@"
Treibstoff: {Treibstoff},
MaxLadung: {MaxLadung}";
        }

        #region static
        public static double KmZuMeilen(int km)
        {
            double miles = km * 0.621371;
            return miles;
        }

        public static int MeilenZuKm(int meilen)
        {
            int km = (int)Math.Round(meilen * 1.60934);
            return km;
        }
        #endregion
    }
}
