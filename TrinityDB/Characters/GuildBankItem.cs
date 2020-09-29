using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildBankItem
    {
        public ulong Guildid { get; set; }
        public byte TabId { get; set; }
        public byte SlotId { get; set; }
        public ulong ItemGuid { get; set; }
    }
}
