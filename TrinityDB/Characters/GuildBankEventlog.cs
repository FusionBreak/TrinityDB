using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildBankEventlog
    {
        public ulong Guildid { get; set; }
        public uint LogGuid { get; set; }
        public byte TabId { get; set; }
        public byte EventType { get; set; }
        public ulong PlayerGuid { get; set; }
        public ulong ItemOrMoney { get; set; }
        public ushort ItemStackCount { get; set; }
        public byte DestTabId { get; set; }
        public uint TimeStamp { get; set; }
    }
}
