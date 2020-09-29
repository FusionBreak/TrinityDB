using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemEffect
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public int CoolDownMsec { get; set; }
        public int CategoryCoolDownMsec { get; set; }
        public short Charges { get; set; }
        public ushort SpellCategoryId { get; set; }
        public ushort ChrSpecializationId { get; set; }
        public byte LegacySlotIndex { get; set; }
        public sbyte TriggerType { get; set; }
        public int ParentItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
