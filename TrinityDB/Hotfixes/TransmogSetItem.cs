using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TransmogSetItem
    {
        public uint Id { get; set; }
        public uint TransmogSetId { get; set; }
        public uint ItemModifiedAppearanceId { get; set; }
        public int Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
