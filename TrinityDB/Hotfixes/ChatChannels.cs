using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChatChannels
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public int Flags { get; set; }
        public sbyte FactionGroup { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
