using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureEquipTemplate
    {
        public uint CreatureId { get; set; }
        public byte Id { get; set; }
        public uint ItemId1 { get; set; }
        public ushort AppearanceModId1 { get; set; }
        public ushort ItemVisual1 { get; set; }
        public uint ItemId2 { get; set; }
        public ushort AppearanceModId2 { get; set; }
        public ushort ItemVisual2 { get; set; }
        public uint ItemId3 { get; set; }
        public ushort AppearanceModId3 { get; set; }
        public ushort ItemVisual3 { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
