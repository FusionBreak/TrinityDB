using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureAddon
    {
        public ulong Guid { get; set; }
        public uint PathId { get; set; }
        public uint Mount { get; set; }
        public uint Bytes1 { get; set; }
        public uint Bytes2 { get; set; }
        public uint Emote { get; set; }
        public short AiAnimKit { get; set; }
        public short MovementAnimKit { get; set; }
        public short MeleeAnimKit { get; set; }
        public string Auras { get; set; }
    }
}
