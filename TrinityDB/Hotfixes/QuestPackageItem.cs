using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class QuestPackageItem
    {
        public uint Id { get; set; }
        public int ItemId { get; set; }
        public ushort PackageId { get; set; }
        public byte DisplayType { get; set; }
        public uint ItemQuantity { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
