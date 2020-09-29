using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SkillRaceClassInfo
    {
        public uint Id { get; set; }
        public long RaceMask { get; set; }
        public short SkillId { get; set; }
        public ushort Flags { get; set; }
        public short SkillTierId { get; set; }
        public sbyte Availability { get; set; }
        public sbyte MinLevel { get; set; }
        public int ClassMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
