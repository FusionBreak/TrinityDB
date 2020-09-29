using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CreatureDifficulty
    {
        public uint Id { get; set; }
        public uint CreatureId { get; set; }
        public uint Flags1 { get; set; }
        public uint Flags2 { get; set; }
        public uint Flags3 { get; set; }
        public uint Flags4 { get; set; }
        public uint Flags5 { get; set; }
        public uint Flags6 { get; set; }
        public uint Flags7 { get; set; }
        public ushort FactionTemplateId { get; set; }
        public sbyte Expansion { get; set; }
        public sbyte MinLevel { get; set; }
        public sbyte MaxLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
