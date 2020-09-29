using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterAchievement
    {
        public ulong Guid { get; set; }
        public uint Achievement { get; set; }
        public uint Date { get; set; }
    }
}
