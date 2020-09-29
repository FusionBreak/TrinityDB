using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CreatureFamily
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public float MinScale { get; set; }
        public float MaxScale { get; set; }
        public int IconFileId { get; set; }
        public short SkillLine1 { get; set; }
        public short SkillLine2 { get; set; }
        public short PetFoodMask { get; set; }
        public sbyte MinScaleLevel { get; set; }
        public sbyte MaxScaleLevel { get; set; }
        public sbyte PetTalentType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
