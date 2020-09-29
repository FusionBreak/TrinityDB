using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GuildRewards
    {
        public uint ItemId { get; set; }
        public byte? MinGuildRep { get; set; }
        public ulong? RaceMask { get; set; }
        public ulong? Cost { get; set; }
    }
}
