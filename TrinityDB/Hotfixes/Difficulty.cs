using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Difficulty
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort GroupSizeHealthCurveId { get; set; }
        public ushort GroupSizeDmgCurveId { get; set; }
        public ushort GroupSizeSpellPointsCurveId { get; set; }
        public byte FallbackDifficultyId { get; set; }
        public byte InstanceType { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public sbyte OldEnumValue { get; set; }
        public byte Flags { get; set; }
        public byte ToggleDifficultyId { get; set; }
        public byte ItemContext { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
