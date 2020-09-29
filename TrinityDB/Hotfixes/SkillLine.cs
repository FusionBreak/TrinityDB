using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SkillLine
    {
        public uint Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string AlternateVerb { get; set; }
        public ushort Flags { get; set; }
        public sbyte CategoryId { get; set; }
        public sbyte CanLink { get; set; }
        public int SpellIconFileId { get; set; }
        public uint ParentSkillLineId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
