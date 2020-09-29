using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterGarrison
    {
        public ulong Guid { get; set; }
        public uint SiteLevelId { get; set; }
        public uint FollowerActivationsRemainingToday { get; set; }
    }
}
