using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetAccountMounts
    {
        public uint BattlenetAccountId { get; set; }
        public uint MountSpellId { get; set; }
        public byte Flags { get; set; }
    }
}
