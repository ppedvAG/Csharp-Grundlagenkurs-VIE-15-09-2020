﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ü_M11_Inheritence
{
    class Flugzeug : Transportmittel
    {
        public int MaxFlugHöhe { get; set; }
        public int GeflogeneKm { get; set; }
        public int MaxLadung { get; set; }
        public Flugzeug(string name, double preis, uint maximalGeschwindigkeit, int maximalFlugHöhe, int geflogeneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            MaxFlugHöhe = maximalFlugHöhe;
            GeflogeneKm = geflogeneKm;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nMaxFlugHöhe: {MaxFlugHöhe}";
        }
    }
}
