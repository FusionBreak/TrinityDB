using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ImportPriceArmor
    {
        public uint Id { get; set; }
        public float ClothModifier { get; set; }
        public float LeatherModifier { get; set; }
        public float ChainModifier { get; set; }
        public float PlateModifier { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
