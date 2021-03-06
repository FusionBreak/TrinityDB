﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemArmorQuality
    {
        public uint Id { get; set; }
        public float Qualitymod1 { get; set; }
        public float Qualitymod2 { get; set; }
        public float Qualitymod3 { get; set; }
        public float Qualitymod4 { get; set; }
        public float Qualitymod5 { get; set; }
        public float Qualitymod6 { get; set; }
        public float Qualitymod7 { get; set; }
        public short ItemLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
