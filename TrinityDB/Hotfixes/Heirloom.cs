using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Heirloom
    {
        public string SourceText { get; set; }
        public int ItemId { get; set; }
        public int LegacyItemId { get; set; }
        public int LegacyUpgradedItemId { get; set; }
        public int StaticUpgradedItemId { get; set; }
        public int UpgradeItemId1 { get; set; }
        public int UpgradeItemId2 { get; set; }
        public int UpgradeItemId3 { get; set; }
        public ushort UpgradeItemBonusListId1 { get; set; }
        public ushort UpgradeItemBonusListId2 { get; set; }
        public ushort UpgradeItemBonusListId3 { get; set; }
        public byte Flags { get; set; }
        public sbyte SourceTypeEnum { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
