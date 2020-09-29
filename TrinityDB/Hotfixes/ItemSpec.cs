using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemSpec
    {
        public uint Id { get; set; }
        public ushort SpecializationId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte ItemType { get; set; }
        public byte PrimaryStat { get; set; }
        public byte SecondaryStat { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
