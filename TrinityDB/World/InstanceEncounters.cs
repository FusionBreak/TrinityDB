using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class InstanceEncounters
    {
        public uint Entry { get; set; }
        public byte CreditType { get; set; }
        public uint CreditEntry { get; set; }
        public ushort LastEncounterDungeon { get; set; }
        public string Comment { get; set; }
    }
}
