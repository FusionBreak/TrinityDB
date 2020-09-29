using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterBanned
    {
        public ulong Guid { get; set; }
        public uint Bandate { get; set; }
        public uint Unbandate { get; set; }
        public string Bannedby { get; set; }
        public string Banreason { get; set; }
        public byte Active { get; set; }
    }
}
