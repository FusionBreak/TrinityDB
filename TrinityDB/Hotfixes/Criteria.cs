using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Criteria
    {
        public uint Id { get; set; }
        public uint Asset { get; set; }
        public int StartAsset { get; set; }
        public int FailAsset { get; set; }
        public uint ModifierTreeId { get; set; }
        public ushort StartTimer { get; set; }
        public short EligibilityWorldStateId { get; set; }
        public byte Type { get; set; }
        public byte StartEvent { get; set; }
        public byte FailEvent { get; set; }
        public byte Flags { get; set; }
        public sbyte EligibilityWorldStateValue { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
