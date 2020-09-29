using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetItemAppearances
    {
        public uint BattlenetAccountId { get; set; }
        public ushort BlobIndex { get; set; }
        public uint AppearanceMask { get; set; }

        public virtual BattlenetAccounts BattlenetAccount { get; set; }
    }
}
