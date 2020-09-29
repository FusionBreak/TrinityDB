using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GroupMember
    {
        public uint Guid { get; set; }
        public ulong MemberGuid { get; set; }
        public byte MemberFlags { get; set; }
        public byte Subgroup { get; set; }
        public byte Roles { get; set; }
    }
}
