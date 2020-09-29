using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MapDifficulty
    {
        public uint Id { get; set; }
        public string Message { get; set; }
        public byte DifficultyId { get; set; }
        public byte ResetInterval { get; set; }
        public byte MaxPlayers { get; set; }
        public byte LockId { get; set; }
        public byte Flags { get; set; }
        public byte ItemContext { get; set; }
        public uint ItemContextPickerId { get; set; }
        public ushort MapId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
