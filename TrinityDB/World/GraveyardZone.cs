using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GraveyardZone
    {
        public uint Id { get; set; }
        public uint GhostZone { get; set; }
        public ushort Faction { get; set; }
        public string Comment { get; set; }
    }
}
