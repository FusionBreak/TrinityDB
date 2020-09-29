using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildBankTab
    {
        public ulong Guildid { get; set; }
        public byte TabId { get; set; }
        public string TabName { get; set; }
        public string TabIcon { get; set; }
        public string TabText { get; set; }
    }
}
