using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CharSections
    {
        public uint Id { get; set; }
        public int MaterialResourcesId1 { get; set; }
        public int MaterialResourcesId2 { get; set; }
        public int MaterialResourcesId3 { get; set; }
        public short Flags { get; set; }
        public sbyte RaceId { get; set; }
        public sbyte SexId { get; set; }
        public sbyte BaseSection { get; set; }
        public sbyte VariationIndex { get; set; }
        public sbyte ColorIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
