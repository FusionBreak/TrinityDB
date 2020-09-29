using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetAccountBans
    {
        public uint Id { get; set; }
        public uint Bandate { get; set; }
        public uint Unbandate { get; set; }
        public string Bannedby { get; set; }
        public string Banreason { get; set; }
    }
}
