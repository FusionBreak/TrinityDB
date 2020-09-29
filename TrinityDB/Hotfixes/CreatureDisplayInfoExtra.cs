using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CreatureDisplayInfoExtra
    {
        public uint Id { get; set; }
        public int BakeMaterialResourcesId { get; set; }
        public int HdbakeMaterialResourcesId { get; set; }
        public sbyte DisplayRaceId { get; set; }
        public sbyte DisplaySexId { get; set; }
        public sbyte DisplayClassId { get; set; }
        public sbyte SkinId { get; set; }
        public sbyte FaceId { get; set; }
        public sbyte HairStyleId { get; set; }
        public sbyte HairColorId { get; set; }
        public sbyte FacialHairId { get; set; }
        public byte CustomDisplayOption1 { get; set; }
        public byte CustomDisplayOption2 { get; set; }
        public byte CustomDisplayOption3 { get; set; }
        public sbyte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
