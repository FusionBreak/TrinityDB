using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildFinderGuildSettings
    {
        public ulong GuildId { get; set; }
        public byte Availability { get; set; }
        public byte ClassRoles { get; set; }
        public byte Interests { get; set; }
        public byte Level { get; set; }
        public byte Listed { get; set; }
        public string Comment { get; set; }
    }
}
