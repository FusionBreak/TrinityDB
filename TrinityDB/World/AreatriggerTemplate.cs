using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class AreatriggerTemplate
    {
        public uint Id { get; set; }
        public byte Type { get; set; }
        public uint Flags { get; set; }
        public float Data0 { get; set; }
        public float Data1 { get; set; }
        public float Data2 { get; set; }
        public float Data3 { get; set; }
        public float Data4 { get; set; }
        public float Data5 { get; set; }
        public string ScriptName { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
