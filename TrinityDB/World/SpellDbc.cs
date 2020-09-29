using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellDbc
    {
        public uint Id { get; set; }
        public uint Attributes { get; set; }
        public uint AttributesEx { get; set; }
        public uint AttributesEx2 { get; set; }
        public uint AttributesEx3 { get; set; }
        public uint AttributesEx4 { get; set; }
        public uint AttributesEx5 { get; set; }
        public uint AttributesEx6 { get; set; }
        public uint AttributesEx7 { get; set; }
        public uint AttributesEx8 { get; set; }
        public uint AttributesEx9 { get; set; }
        public uint AttributesEx10 { get; set; }
        public uint CastingTimeIndex { get; set; }
        public uint DurationIndex { get; set; }
        public uint RangeIndex { get; set; }
        public uint SchoolMask { get; set; }
        public uint SpellAuraOptionsId { get; set; }
        public uint SpellCastingRequirementsId { get; set; }
        public uint SpellCategoriesId { get; set; }
        public uint SpellClassOptionsId { get; set; }
        public uint SpellEquippedItemsId { get; set; }
        public uint SpellLevelsId { get; set; }
        public uint SpellTargetRestrictionsId { get; set; }
        public uint SpellInterruptsId { get; set; }
        public string Comment { get; set; }
    }
}
