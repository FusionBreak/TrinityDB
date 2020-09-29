using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class DungeonEncounter
    {
        public string Name { get; set; }
        public int CreatureDisplayId { get; set; }
        public short MapId { get; set; }
        public sbyte DifficultyId { get; set; }
        public sbyte Bit { get; set; }
        public byte Flags { get; set; }
        public uint Id { get; set; }
        public int OrderIndex { get; set; }
        public int SpellIconFileId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
