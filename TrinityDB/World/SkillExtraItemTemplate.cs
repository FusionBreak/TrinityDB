﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SkillExtraItemTemplate
    {
        public uint SpellId { get; set; }
        public uint RequiredSpecialization { get; set; }
        public float AdditionalCreateChance { get; set; }
        public byte AdditionalMaxNum { get; set; }
    }
}
