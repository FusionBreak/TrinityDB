﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CharacterFacialHairStyles
    {
        public uint Id { get; set; }
        public int Geoset1 { get; set; }
        public int Geoset2 { get; set; }
        public int Geoset3 { get; set; }
        public int Geoset4 { get; set; }
        public int Geoset5 { get; set; }
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte VariationId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
