using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildEventlog
    {
        public ulong Guildid { get; set; }
        public uint LogGuid { get; set; }
        public byte EventType { get; set; }
        public ulong PlayerGuid1 { get; set; }
        public ulong PlayerGuid2 { get; set; }
        public byte NewRank { get; set; }
        public uint TimeStamp { get; set; }
    }
}
