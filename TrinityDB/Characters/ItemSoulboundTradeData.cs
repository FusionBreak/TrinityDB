using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemSoulboundTradeData
    {
        public ulong ItemGuid { get; set; }
        public string AllowedPlayers { get; set; }
    }
}
