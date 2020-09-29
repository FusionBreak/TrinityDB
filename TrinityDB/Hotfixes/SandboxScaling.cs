using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SandboxScaling
    {
        public uint Id { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
