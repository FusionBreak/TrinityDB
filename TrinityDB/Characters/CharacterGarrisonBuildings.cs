using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterGarrisonBuildings
    {
        public ulong Guid { get; set; }
        public uint PlotInstanceId { get; set; }
        public uint BuildingId { get; set; }
        public ulong TimeBuilt { get; set; }
        public byte Active { get; set; }
    }
}
