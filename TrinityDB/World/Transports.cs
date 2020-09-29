using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Transports
    {
        public ulong Guid { get; set; }
        public uint Entry { get; set; }
        public string Name { get; set; }
        public byte PhaseUseFlags { get; set; }
        public int Phaseid { get; set; }
        public int Phasegroup { get; set; }
        public string ScriptName { get; set; }
    }
}
