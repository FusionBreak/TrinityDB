using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class EmotesText
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort EmoteId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
