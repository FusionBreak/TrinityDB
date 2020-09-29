using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellMisc
    {
        public uint Id { get; set; }
        public ushort CastingTimeIndex { get; set; }
        public ushort DurationIndex { get; set; }
        public ushort RangeIndex { get; set; }
        public byte SchoolMask { get; set; }
        public int SpellIconFileDataId { get; set; }
        public float Speed { get; set; }
        public int ActiveIconFileDataId { get; set; }
        public float LaunchDelay { get; set; }
        public byte DifficultyId { get; set; }
        public int Attributes1 { get; set; }
        public int Attributes2 { get; set; }
        public int Attributes3 { get; set; }
        public int Attributes4 { get; set; }
        public int Attributes5 { get; set; }
        public int Attributes6 { get; set; }
        public int Attributes7 { get; set; }
        public int Attributes8 { get; set; }
        public int Attributes9 { get; set; }
        public int Attributes10 { get; set; }
        public int Attributes11 { get; set; }
        public int Attributes12 { get; set; }
        public int Attributes13 { get; set; }
        public int Attributes14 { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
