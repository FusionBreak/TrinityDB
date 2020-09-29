using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterPvpTalent
    {
        public ulong Guid { get; set; }
        public uint TalentId { get; set; }
        public byte TalentGroup { get; set; }
    }
}
