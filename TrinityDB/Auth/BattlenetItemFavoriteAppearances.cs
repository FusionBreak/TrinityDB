using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetItemFavoriteAppearances
    {
        public uint BattlenetAccountId { get; set; }
        public uint ItemModifiedAppearanceId { get; set; }

        public virtual BattlenetAccounts BattlenetAccount { get; set; }
    }
}
