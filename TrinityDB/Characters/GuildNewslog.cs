using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildNewslog
    {
        public ulong Guildid { get; set; }
        public uint LogGuid { get; set; }
        public byte EventType { get; set; }
        public ulong PlayerGuid { get; set; }
        public uint Flags { get; set; }
        public uint Value { get; set; }
        public uint TimeStamp { get; set; }
    }
}
