using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildBankRight
    {
        public ulong Guildid { get; set; }
        public byte TabId { get; set; }
        public byte Rid { get; set; }
        public sbyte Gbright { get; set; }
        public int SlotPerDay { get; set; }
    }
}
