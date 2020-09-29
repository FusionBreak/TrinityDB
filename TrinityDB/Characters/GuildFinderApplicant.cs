using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildFinderApplicant
    {
        public ulong GuildId { get; set; }
        public ulong PlayerGuid { get; set; }
        public byte? Availability { get; set; }
        public byte? ClassRole { get; set; }
        public byte? Interests { get; set; }
        public string Comment { get; set; }
        public uint? SubmitTime { get; set; }
    }
}
