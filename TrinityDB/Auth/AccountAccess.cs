using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class AccountAccess
    {
        public uint Id { get; set; }
        public byte Gmlevel { get; set; }
        public int RealmId { get; set; }
    }
}
