using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterAuraEffect
    {
        public ulong Guid { get; set; }
        public byte[] CasterGuid { get; set; }
        public byte[] ItemGuid { get; set; }
        public uint Spell { get; set; }
        public uint EffectMask { get; set; }
        public byte EffectIndex { get; set; }
        public int Amount { get; set; }
        public int BaseAmount { get; set; }
    }
}
