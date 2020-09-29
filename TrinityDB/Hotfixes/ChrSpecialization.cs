using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChrSpecialization
    {
        public string Name { get; set; }
        public string FemaleName { get; set; }
        public string Description { get; set; }
        public int MasterySpellId1 { get; set; }
        public int MasterySpellId2 { get; set; }
        public sbyte ClassId { get; set; }
        public sbyte OrderIndex { get; set; }
        public sbyte PetTalentType { get; set; }
        public sbyte Role { get; set; }
        public sbyte PrimaryStatPriority { get; set; }
        public uint Id { get; set; }
        public int SpellIconFileId { get; set; }
        public uint Flags { get; set; }
        public int AnimReplacements { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
