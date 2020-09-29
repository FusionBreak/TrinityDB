using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Item
    {
        public uint Id { get; set; }
        public int IconFileDataId { get; set; }
        public byte ClassId { get; set; }
        public byte SubclassId { get; set; }
        public sbyte SoundOverrideSubclassId { get; set; }
        public byte Material { get; set; }
        public byte InventoryType { get; set; }
        public byte SheatheType { get; set; }
        public byte ItemGroupSoundsId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
