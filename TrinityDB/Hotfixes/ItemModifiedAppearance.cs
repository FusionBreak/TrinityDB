using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemModifiedAppearance
    {
        public int ItemId { get; set; }
        public uint Id { get; set; }
        public byte ItemAppearanceModifierId { get; set; }
        public ushort ItemAppearanceId { get; set; }
        public byte OrderIndex { get; set; }
        public sbyte TransmogSourceTypeEnum { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
