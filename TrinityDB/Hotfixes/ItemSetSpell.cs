using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemSetSpell
    {
        public uint Id { get; set; }
        public uint SpellId { get; set; }
        public ushort ChrSpecId { get; set; }
        public byte Threshold { get; set; }
        public ushort ItemSetId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
