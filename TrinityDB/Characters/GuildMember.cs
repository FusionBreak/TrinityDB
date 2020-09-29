using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildMember
    {
        public ulong Guildid { get; set; }
        public ulong Guid { get; set; }
        public byte Rank { get; set; }
        public string Pnote { get; set; }
        public string Offnote { get; set; }
    }
}
