using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BattlePetBreedQuality
    {
        public uint Id { get; set; }
        public float StateMultiplier { get; set; }
        public byte QualityEnum { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
