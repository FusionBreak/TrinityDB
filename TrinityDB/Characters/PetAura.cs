using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class PetAura
    {
        public uint Guid { get; set; }
        public byte[] CasterGuid { get; set; }
        public uint Spell { get; set; }
        public uint EffectMask { get; set; }
        public uint RecalculateMask { get; set; }
        public byte StackCount { get; set; }
        public int MaxDuration { get; set; }
        public int RemainTime { get; set; }
        public byte RemainCharges { get; set; }
    }
}
