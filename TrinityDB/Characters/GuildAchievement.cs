using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildAchievement
    {
        public ulong GuildId { get; set; }
        public uint Achievement { get; set; }
        public uint Date { get; set; }
        public string Guids { get; set; }
    }
}
