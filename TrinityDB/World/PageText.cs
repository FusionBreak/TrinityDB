using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PageText
    {
        public uint Id { get; set; }
        public string Text { get; set; }
        public uint NextPageId { get; set; }
        public int PlayerConditionId { get; set; }
        public byte Flags { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
